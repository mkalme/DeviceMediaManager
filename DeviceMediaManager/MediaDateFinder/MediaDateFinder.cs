using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using MediaDuplicateSeperator;

namespace DeviceMediaManager {
    public class MediaDateFinder : IMediaDateFinder {
        public IEnumerable<Format> Formats { get; set; }
        public IMediaDateFinderFactory MediaDateFinderFactory { get; set; }

        public MediaDateFinder(IEnumerable<Format> formats) {
            Formats = formats;
            MediaDateFinderFactory = new MediaDateFinderFactory();
        }

        public bool TryFindDate(string path, out DateTime dateTime) {
            string name = Path.GetFileNameWithoutExtension(path);

            dateTime = DateTime.MinValue;
            foreach (Format format in Formats) {
                if (name.Length <= format.SkipFirstCharacters) continue;

                try {
                    string substring = name.Substring(format.SkipFirstCharacters, format.DateFormat.Length);
                    dateTime = DateTime.ParseExact(substring, format.DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None);
                    
                    break;
                } catch { }
            }

            if (dateTime != DateTime.MinValue) return true;

            IMediaDateFinder dateFinder = MediaDateFinderFactory.CreateMediaDateFinder(path);
            if (dateFinder != null) {
                try {
                    return dateFinder.TryFindDate(path, out dateTime);
                } catch {}
            }

            return false;
        }
    }
}
