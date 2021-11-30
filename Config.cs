using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CorseProject
{
    public class Config
    {
        private static readonly string name = "config.json";
        private static Dictionary<string, string> dict = null;

        public static string GetValue(string key)
        {
            if (dict == null)
            {
                string path = Directory.GetCurrentDirectory() + $@"\{name}";
                string json = null;
                using (StreamReader sr = new StreamReader(path))
                {
                    json = sr.ReadToEnd();
                }
                dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }
            return dict[key];
        }
    }
}
