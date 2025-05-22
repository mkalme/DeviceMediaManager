using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FastBinaryIO;

namespace DeviceMediaManager {
    public class SortResultStreamDeserializer {
        public SortResult Deserialize(Stream input) {
            FastBinaryStreamReader reader = new FastBinaryStreamReader(input);

            DateTime time = DateTime.FromBinary(reader.ReadInt64());

            string[] directories = reader.ReadStringArray(reader.ReadInt32());
            HashSet<string> filePaths = new HashSet<string>(reader.ReadStringArray(reader.ReadInt32()));

            List<FileSortResult> sortResults = ReadFileSortResults(directories, filePaths, reader);            
            foreach (var result in sortResults) {
                foreach (var directory in directories) {
                    if (result.CopyResults.Where(x => x.OutputPath.StartsWith(directory)).Any()) continue;
                    result.CopyResults.Add(new FileCopyResult(directory, CopyResult.ErrorWhileCopying, result));
                }

                filePaths.Remove(result.FilePath);
            }

            List<FileSortResult> output = new List<FileSortResult>(sortResults);
            foreach (var file in filePaths) {
                FileSortResult result = new FileSortResult() { 
                    FilePath = file
                };

                foreach (var directory in directories) {
                    result.CopyResults.Add(new FileCopyResult(directory, CopyResult.ErrorWhileCopying, result));
                }

                output.Add(result);
            }

            return new SortResult() { 
                SortStarted = time,
                SortResults = output
            };
        }

        private static List<FileSortResult> ReadFileSortResults(IEnumerable<string> directories, IEnumerable<string> filePaths, FastBinaryStreamReader reader) {
            Dictionary<int, FileSortResult> fileSortResults = new Dictionary<int, FileSortResult>(filePaths.Count());

            foreach (string directory in directories) {
                foreach (string filePath in filePaths) {
                    try {
                        int index = reader.ReadInt32();

                        if (!fileSortResults.TryGetValue(index, out FileSortResult result)) {
                            result = new FileSortResult() {
                                FilePath = filePath,
                                Date = DateTime.FromBinary(reader.ReadInt64()),
                                NewFileName = reader.ReadString()
                            };

                            fileSortResults.Add(index, result);
                        }
                        
                        result.CopyResults.Add(ReadFileCopyResult(result, reader));
                    } catch {
                        return new List<FileSortResult>(fileSortResults.Values);
                    }
                }
            }

            return new List<FileSortResult>(fileSortResults.Values);
        }
        private static FileCopyResult ReadFileCopyResult(FileSortResult file, FastBinaryStreamReader reader) {
            CopyResult copyResult = (CopyResult)reader.ReadByte();
            if (copyResult == CopyResult.NoCopyCreationDateNotFound) return new FileCopyResult("none", copyResult, file);

            string fileOutput = reader.ReadString();
            if(copyResult == CopyResult.NoCopyDuplicateFound) return new FileCopyResult(fileOutput, copyResult, file);

            if (reader.BaseStream.Position >= reader.BaseStream.Length) {
                copyResult = CopyResult.ErrorWhileCopying;
            }

            return new FileCopyResult(fileOutput, copyResult, file);
        }
    }
}
