using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FastBinaryIO;

namespace DeviceMediaManager {
    public class Scheme : ICloneable {
        public string Name {
            get => _name;
            set {
                if (_name == value) return;

                _name = value;
                CallUpdate();
            }
        }
        private string _name;

        public string[] OutputDirectories {
            get => _outputDirectories;
            set {
                _outputDirectories = value;
                CallUpdate();
            }
        }
        private string[] _outputDirectories;

        public IList<Format> Formats { get; set; }
        public string OutputFormat { get; set; }

        public event EventHandler Update;

        public ApplicationManager Manager { get; set; }
        public IMediaSorter MediaSorter { get; set; }

        public Scheme(ApplicationManager manager) {
            OutputDirectories = new string[0];
            Formats = new List<Format>();
            OutputFormat = "";

            Manager = manager;
            MediaSorter = new MediaSorter(this);
        }

        private void CallUpdate() {
            if (Update != null) Update(this, EventArgs.Empty);
        }

        public object Clone() {
            Scheme scheme = new Scheme(Manager) {
                Name = Name,
                OutputDirectories = CloneArray(OutputDirectories),
                Formats = new List<Format>(Formats.Count),
                OutputFormat = OutputFormat
            };

            foreach (var format in Formats) {
                scheme.Formats.Add(format.Clone() as Format);
            }

            return scheme;
        }
        private static string[] CloneArray(string[] array) {
            string[] output = new string[array.Length];

            Array.Copy(array, output, array.Length);

            return output;
        }

        public SortResult SortMedia(IEnumerable<string> files, IProgress<ProgressReport> progress) {
            Progress<IndexedProgressReport<FileSortResult>> dateProgress = new Progress<IndexedProgressReport<FileSortResult>>();
            dateProgress.ProgressChanged += (sender, report) => FileDateProgress(files, report, progress);
            SortResult output = MediaSorter.ExtractDates(files, dateProgress);

            Progress<IndexedProgressReport<FileCopyResult>> sortProgress = new Progress<IndexedProgressReport<FileCopyResult>>();
            sortProgress.ProgressChanged += (sender, report) => FileSortProgress(files, report, progress);

            Directory.CreateDirectory(Manager.SortResultDirectory);
            string fileName = $"{Manager.SortResultDirectory}\\{output.SortStarted.ToString("yyyy-MM-dd_HHmmss.fff")}.fcl";
            using (FastBinaryStreamWriter writer = new FastBinaryStreamWriter(File.Create(fileName), false)) {
                MediaSorter.SortMedia(output, writer, sortProgress);
            }

            progress.Report(new ProgressReport(1, "Finished", "", true));

            return output;
        }

        private void FileDateProgress(IEnumerable<string> files, IndexedProgressReport<FileSortResult> report, IProgress<ProgressReport> progress) {
            progress.Report(new ProgressReport() {
                Percentage = report.Index / (float)files.Count(),
                ActivityType = "Extracting creation date",
                Message = Path.GetFileName(report.Report.FilePath)
            });
        }
        private void FileSortProgress(IEnumerable<string> files, IndexedProgressReport<FileCopyResult> report, IProgress<ProgressReport> progress) {
            string activityType, message = $"({report.Index} / {files.Count()})";

            if (report.Report.CopyResult != CopyResult.NoCopyDuplicateFound) {
                activityType = $"Copying to {Path.GetDirectoryName(report.Report.OutputPath)}";
                message = $"{Path.GetFileName(report.Report.Parent.FilePath)} {message}";
            } else {
                activityType = $"{report.Report.Parent.FilePath}";
                message = $"Skipping {message}";
            }

            progress.Report(new ProgressReport() {
                Percentage = report.Index / (float)files.Count(),
                ActivityType = activityType,
                Message = message
            });
        }
    }
}
