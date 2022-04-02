using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace modul6_kelompok_rojak
{
    public class teamMembers_1302202072
    {
        public void readJson()
        {
            StreamReader r = new StreamReader("jurnal6_2_1302202072.json");
            string jsonString = r.ReadToEnd();
            JObject parsed = JObject.Parse(jsonString);

             var members = parsed["members"];

            Console.WriteLine("LIST ANGGOTA KELMPOK ROJAK :");
            foreach (var member in members)
            {
                Console.WriteLine("\t{0} {1} {2} ({3} {4})", member["nim"], member["firstName"], member["lastName"], member["age"], member["gender"]);

            }

        }
    }
}
