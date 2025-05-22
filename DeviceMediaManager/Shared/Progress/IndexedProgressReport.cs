using System;

namespace DeviceMediaManager {
    public readonly struct IndexedProgressReport<TReport> {
        public int Index { get; }
        public TReport Report { get; }

        public IndexedProgressReport(int index, TReport report) {
            Index = index;
            Report = report;
        }
    }
}
