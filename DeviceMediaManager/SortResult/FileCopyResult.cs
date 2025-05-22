using System;
using Newtonsoft.Json;

namespace DeviceMediaManager {
    public class FileCopyResult {
        [JsonIgnore]
        public FileSortResult Parent { get; }

        public string OutputPath { get; set; }
        public CopyResult CopyResult { get; set; }

        public FileCopyResult(string outputPath, CopyResult copyResult, FileSortResult parent) {
            OutputPath = outputPath;
            CopyResult = copyResult;
            Parent = parent;
        }
    }
}
