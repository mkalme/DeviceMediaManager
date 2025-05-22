using System;
using System.Collections.Generic;

namespace DeviceMediaManager {
    public class SortResult {
        public DateTime SortStarted { get; set; } = DateTime.Now;
        public IList<FileSortResult> SortResults { get; set; } = new List<FileSortResult>();
    }
}
