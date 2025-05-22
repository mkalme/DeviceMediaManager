using System;
using System.Collections.Generic;
using System.IO;
using BinaryObjectFormat;

namespace DeviceMediaManager {
    public class ApplicationSerializer {
        public void Serialize(IList<Scheme> schemes, Stream output) {
            Tag tag = schemes.Serialize(scheme => {
                return new ObjectTag() {
                    { "Name", scheme.Name },
                    { "OutputDirectories", scheme.OutputDirectories },
                    { "OutputFormat", scheme.OutputFormat },
                    { "Formats", scheme.Formats.Serialize(format => SerializeFormat(format)) },
                };
            });

            tag.Serialize(output);
        }

        private static ObjectTag SerializeFormat(Format format) {
            return new ObjectTag() {
                { "DateFormat", format.DateFormat },
                { "SkipFirstCharacters", format.SkipFirstCharacters }
            };
        }
    }
}
