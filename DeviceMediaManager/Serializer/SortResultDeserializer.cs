using System;
using System.IO;
using Newtonsoft.Json;

namespace DeviceMediaManager {
    public class SortResultDeserializer {
        public SortResult Deserialize(Stream input) {
            using (StreamReader reader = new StreamReader(input)) {
                return JsonConvert.DeserializeObject<SortResult>(reader.ReadToEnd());
            }
        }
    }
}
