using System;

namespace DeviceMediaManager {
    public enum CopyResult {
        CopyOriginal,
        CopyNameOriginal,
        NoCopyDuplicateFound,
        NoCopyCreationDateNotFound,
        ErrorWhileCopying,
        CopyingNotStarted
    }
}
