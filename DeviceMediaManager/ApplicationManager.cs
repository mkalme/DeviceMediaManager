using System;
using System.Collections.Generic;
using System.IO;

namespace DeviceMediaManager {
    public class ApplicationManager {
        public IList<Scheme> Schemes { get; set; }
        public string Path { get; set; }

        public string SortResultDirectory { get; } = "Storage\\SortResults";

        public ApplicationManager(string path) {
            Schemes = new List<Scheme>();
            Path = path;
        }

        public void Load() {
            if (!File.Exists(Path)) {
                Save();

                return;
            }

            using (FileStream fileStream = File.OpenRead(Path)) {
                Schemes = new ApplicationDeserializer() {
                    Manager = this
                }.Deserialize(fileStream);
            }
        }
        public void Save() {
            using (FileStream fileStream = File.Create(Path)) {
                fileStream.SetLength(0);

                new ApplicationSerializer().Serialize(Schemes, fileStream);
            }
        }
    }
}
