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
    public class GlosarryItem_1302203120
    {
        public static void readJson()
        {
            StreamReader r = new StreamReader("jurnal6_3_1302203120.json");
            string jsonString = r.ReadToEnd();
            JObject parsed = JObject.Parse(jsonString);

            var glossary = parsed["glossary"];
            var glossDiv = glossary["GlossDiv"];
            var glossList = glossDiv["GlossList"];
            var glossEntry = glossList["GlossEntry"];
            var glossDef = glossEntry["GlossDef"];

            Console.WriteLine("<ID: {0}> <SortAs: {1}> <GlossTerm: {2}> \n" +
                              "<Acronym: {3}> <Abbrev: {4}> \n" +
                              "<GlossDef-para: {5}> \n<GlossDef-see: 1. {6} 2. {7} > \n" +
                              "<GlossSee: {8}>)",
             glossEntry["ID"], glossEntry["SortAs"], glossEntry["GlossTerm"], glossEntry["Acronym"], glossEntry["Abbrev"],
             glossDef["para"], glossDef["GlossSeeAlso"][0], glossDef["GlossSeeAlso"][1],
             glossEntry["GlossSee"]);


        }
    }
}
