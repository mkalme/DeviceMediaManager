using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FastBinaryIO;
using MediaDuplicateSeperator;

namespace DeviceMediaManager {
    public class MediaSorter : IMediaSorter {
        public Scheme Scheme { get; set; }

        public IMediaDateFinder MediaDateFinder { get; set; }
        public IMediaComparer MediaComparer { get; set; }

        public MediaSorter(Scheme scheme) {
            Scheme = scheme;

            MediaComparer = CreateMediaComparer();
        }

        private IMediaComparer CreateMediaComparer() {
            return new MediaComparer() { 
                MediaComparerFactory = new MediaComparerFactory()
            };
        }


        public SortResult ExtractDates(IEnumerable<string> files, IProgress<IndexedProgressReport<FileSortResult>> progress) {
            MediaDateFinder = new MediaDateFinder(Scheme.Formats);

            SortResult output = new SortResult();

            int count = 0;
            foreach (var file in files) {
                output.SortResults.Add(new FileSortResult() {
                    FilePath = file,
                    Date = MediaDateFinder.TryFindDate(file, out DateTime date) ? date : DateTime.MinValue,
                    NewFileName = $"{date.ToString(Scheme.OutputFormat)}{Path.GetExtension(file)}"
                });

                progress.Report(new IndexedProgressReport<FileSortResult>(count, output.SortResults[count++]));
            }

            return output;
        }
        public void SortMedia(SortResult sortResults, FastBinaryWriter writer, IProgress<IndexedProgressReport<FileCopyResult>> progress) {
            writer.Write(sortResults.SortStarted.ToBinary());

            writer.Write(Scheme.OutputDirectories.Length);
            writer.Write(Scheme.OutputDirectories);

            writer.Write(sortResults.SortResults.Count);
            writer.Write(sortResults.SortResults.Select(x => x.FilePath).ToArray());

            int index = 0;
            foreach (var outputDirectory in Scheme.OutputDirectories) {
                for (int i = 0; i < sortResults.SortResults.Count; i++) {
                    writer.Write(i);

                    if (index == 0) {
                        writer.Write(sortResults.SortResults[i].Date.ToBinary());
                        writer.Write(sortResults.SortResults[i].NewFileName);
                    }
                    
                    FileCopyResult results = CopyFile(sortResults.SortResults[i], writer, outputDirectory);
                    sortResults.SortResults[i].CopyResults.Add(results);

                    progress.Report(new IndexedProgressReport<FileCopyResult>(i, results));
                }

                index++;
            }

            writer.Write((byte)127);
        }
        
        private FileCopyResult CopyFile(FileSortResult file, FastBinaryWriter writer, string outputDirectory) {
            if (file.Date == DateTime.MinValue) {
                writer.Write((byte)CopyResult.NoCopyCreationDateNotFound);

                return new FileCopyResult("none", CopyResult.NoCopyCreationDateNotFound, file);
            }

            string filePath = $"{GetDirectory(file.Date, outputDirectory)}\\{file.NewFileName}";
            CopyResult copyResult = CopyResult.CopyOriginal;

            int count = 2;
            string original = filePath;

            while (File.Exists(filePath)) {
                if (MediaComparer.TryCompare(file.FilePath, filePath, out bool equals) && equals) {
                    writer.Write((byte)CopyResult.NoCopyDuplicateFound);
                    writer.Write(filePath);

                    return new FileCopyResult(filePath, CopyResult.NoCopyDuplicateFound, file);
                }

                filePath = $"{Path.GetDirectoryName(original)}\\{Path.GetFileNameWithoutExtension(original)} ({count++}){Path.GetExtension(original)}";
                copyResult = CopyResult.CopyNameOriginal;
            }

            writer.Write((byte)copyResult);
            writer.Write(filePath);

            File.Copy(file.FilePath, filePath);

            return new FileCopyResult(filePath, copyResult, file);
        }

        private static string GetDirectory(DateTime date, string baseDirectory) {
            string output = $"{baseDirectory}\\{date.ToString("yyyy-MM")}";
            Directory.CreateDirectory(output);

            return output;
        }
    }
}
