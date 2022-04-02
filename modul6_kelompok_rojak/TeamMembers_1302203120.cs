using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace modul6_kelompok_rojak
{
    public class TeamMembers_1302203120
    {
        public static void readJson()
        {
            StreamReader r = new StreamReader("jurnal6_2_1302203120.json");
            string jsonString = r.ReadToEnd();
            JObject parsed = JObject.Parse(jsonString);

            var members = parsed["members"];
            var member1 = members[0];
            var member2 = members[1];
            var member3 = members[2];

            Console.WriteLine("<{0}> <{1} {2}> (<{3}> <{4}>) \n" +
                              "<{5}> <{6} {7}> (<{8}> <{9}>) \n" +
                              "<{10}> <{11} {12}> (<{13}> <{14}>)",
             member1["nim"], member1["firstName"], member1["lastName"], member1["age"], member1["gender"],
             member2["nim"], member2["firstName"], member2["lastName"], member2["age"], member2["gender"],
             member3["nim"], member3["firstName"], member3["lastName"], member3["age"], member3["gender"]);

        }

    }
}
