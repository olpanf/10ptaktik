using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Практическая
{
    internal class SandDs
    {
        public static void Ds()
        {
            string Tuk = File.ReadAllText("D:\\10 Практическая\\Данные.json");
            List<List<string>> Vse = JsonConvert.DeserializeObject<List<List<string>>>(Tuk);
            Global.AllVse = Vse;
        }
        public static void S()
        {
            string json = JsonConvert.SerializeObject(Global.AllVse);
            File.WriteAllText("D:\\10 Практическая\\Данные.json", json);
        }
    }
}
