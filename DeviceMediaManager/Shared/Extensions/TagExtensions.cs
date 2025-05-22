using System;
using System.Collections.Generic;
using BinaryObjectFormat;

namespace DeviceMediaManager {
    public static class TagExtensions {
        public static IList<T> Deserialize<T>(this ObjectTag[] array, Func<ObjectTag, T> function) {
            List<T> output = new List<T>(array.Length);

            foreach (ObjectTag obj in array) {
                output.Add(function(obj));
            }

            return output;
        }
        public static ObjectTag[] Serialize<T>(this IList<T> list, Func<T, ObjectTag> function) {
            ObjectTag[] output = new ObjectTag[list.Count];

            for (int i = 0; i < list.Count; i++) {
                output[i] = function(list[i]);
            }

            return output;
        }
    }
}
