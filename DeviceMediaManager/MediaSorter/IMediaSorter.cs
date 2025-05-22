using System;
using System.Collections.Generic;
using FastBinaryIO;

namespace DeviceMediaManager {
    public interface IMediaSorter {
        SortResult ExtractDates(IEnumerable<string> files, IProgress<IndexedProgressReport<FileSortResult>> progress);
        void SortMedia(SortResult sortResults, FastBinaryWriter Writer, IProgress<IndexedProgressReport<FileCopyResult>> progress);
    }
}
