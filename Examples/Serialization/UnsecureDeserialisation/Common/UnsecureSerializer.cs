using System;
using Newtonsoft.Json;

namespace Common
{
    public static class UnsecureSerializer<T>
    {

        public static string Serialize(T item)
        {
            return JsonConvert.SerializeObject(item, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
        }
        public static T Deserialize(string item)
        {
            return JsonConvert.DeserializeObject<T>(item, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
        }
    }
}