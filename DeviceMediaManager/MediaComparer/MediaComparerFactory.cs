using System;
using System.IO;
using MediaDuplicateSeperator;

namespace DeviceMediaManager {
    public class MediaComparerFactory : IMediaComparerFactory {
        public IMediaComparer CreateMediaComparer(string firstPath, string secondPath) {
            string firstExtension = Path.GetExtension(firstPath).ToLower();
            string secondExtension = Path.GetExtension(secondPath).ToLower();

            if (MediaUtilities.ImageFormats.Contains(firstExtension) && MediaUtilities.ImageFormats.Contains(secondExtension)) {
                return new ImageComparer() {
                    DisposeAfterComparison = true
                };
            } else if (MediaUtilities.VideoFormats.Contains(firstExtension) && MediaUtilities.VideoFormats.Contains(secondExtension)) {
                return new VideoComparer() {
                    Shallow = false
                };
            }

            return null;
        }
    }
}
