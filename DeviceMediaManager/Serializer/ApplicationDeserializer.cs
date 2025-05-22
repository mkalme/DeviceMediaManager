using System;
using System.Collections.Generic;
using System.IO;
using BinaryObjectFormat;

namespace DeviceMediaManager {
    public class ApplicationDeserializer {
        public ApplicationManager Manager { get; set; }

        public IList<Scheme> Deserialize(Stream input) {
            ObjectTag[] array = Tag.FromStream(input);

            return array.Deserialize(schemeObj => {
                return new Scheme(Manager) {
                    Name = schemeObj["Name"],
                    OutputDirectories = schemeObj["OutputDirectories"],
                    OutputFormat = schemeObj["OutputFormat"],
                    Formats = ((ObjectTag[])schemeObj["Formats"]).Deserialize(formatObj => DeserializeFormat(formatObj))
                };
            });
        }
        private static Format DeserializeFormat(ObjectTag obj) {
            return new Format() {
                DateFormat = obj["DateFormat"],
                SkipFirstCharacters = obj["SkipFirstCharacters"]
            };
        }
    }
}
