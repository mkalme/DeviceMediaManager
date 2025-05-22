using System;

namespace DeviceMediaManager {
    public class FileDate {
        public string OldPath { get; set; }
        public string NewPath { get; set; }
        public DateTime Date { get; set; }

        public FileDate(string oldPath, string newPath, DateTime date) {
            OldPath = oldPath;
            NewPath = newPath;
            Date = date;
        }
    }
}
