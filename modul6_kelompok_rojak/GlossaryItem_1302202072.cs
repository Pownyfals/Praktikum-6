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
    public class GlossaryItem_1302202072
    {
        public void readJson()
        {
            StreamReader r = new StreamReader("jurnal6_3_1302202072.json");
            string jsonString = r.ReadToEnd();
            JObject parsed = JObject.Parse(jsonString);

            var glossary = parsed["glossary"];
            
            var glossdiv = glossary["GlossDiv"];
            

            var glosslist = glossdiv["GlossList"];


            var glossentry = glosslist["GlossEntry"];

            Console.WriteLine("Gloss Entry :\n");

            foreach (var item in glossentry)
            {
                Console.WriteLine("\t {0}", item);    
            }

        }
    }
}
