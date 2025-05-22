using System;

namespace DeviceMediaManager {
    public class Format : ICloneable {
        public string DateFormat { get; set; }
        public int SkipFirstCharacters { get; set; }

        public Format() {
            DateFormat = "";
            SkipFirstCharacters = 0;
        }

        public object Clone() {
            return new Format() { 
                DateFormat = DateFormat,
                SkipFirstCharacters = SkipFirstCharacters
            };
        }
    }
}
