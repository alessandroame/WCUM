using Newtonsoft.Json;
using System;
using System.IO;

namespace Storage
{
    public class JSONStorage
    {
        public static T Load<T>(string filename)
        {
            var json = File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
