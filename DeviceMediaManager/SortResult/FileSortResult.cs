using System;
using System.Collections.Generic;

namespace DeviceMediaManager {
    public class FileSortResult {
        public string FilePath { get; set; }

        public DateTime Date { get; set; }
        public string NewFileName { get; set; }

        public IList<FileCopyResult> CopyResults { get; set; } = new List<FileCopyResult>();
    }
}
