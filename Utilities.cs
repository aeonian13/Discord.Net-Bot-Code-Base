using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Bot_Boi
{
    class Utilities
    {
        private static readonly Dictionary<string, string> alert;

        static Utilities()
        {
            string json = File.ReadAllText("SystemLang/alert.json");
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            alert = data.ToObject<Dictionary<string, string>>();
        }
        public static string GetAlert(string key)
        {
            if (alert.ContainsKey(key)) return alert[key];
            return "";
        }
    }
}
