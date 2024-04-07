using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
    internal class SER_DES
    {
        public static T Des<T>(string path)
        {
            string j = File.ReadAllText(path);
            T a = JsonConvert.DeserializeObject<T>(j);
            return a;
        }
        public static void Ser<T>(T a, string path)
        {
            string j = JsonConvert.SerializeObject(a);
            File.WriteAllText(path, j);
        }
    }
}
