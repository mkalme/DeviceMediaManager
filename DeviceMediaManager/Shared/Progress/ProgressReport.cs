using System;
using CustomDialogs;

namespace DeviceMediaManager {
    public class ProgressReport : IProgressReport {
        public float Percentage { get; init; }
        public string Message { get; init; }
        public string ActivityType { get; init; }

        public bool Finished { get; init; } = false;

        public ProgressReport() {}
        public ProgressReport(float percentage, string message, string activityType, bool finished = false) {
            Percentage = percentage;
            Message = message;
            ActivityType = activityType;
            Finished = finished;
        }
    }
}
