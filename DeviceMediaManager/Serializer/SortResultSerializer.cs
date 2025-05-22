using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DeviceMediaManager {
    public class SortResultSerializer {
        public void Serialize(SortResult result, Stream output) {
            using (StreamWriter writer = new StreamWriter(output)) {
                StringEnumConverter converter = new StringEnumConverter();

                writer.Write(JsonConvert.SerializeObject(result, Formatting.Indented, converter));
            }
        }
    }
}
