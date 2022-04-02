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
	internal class GlossaryItem_1302204081
	{
		public void readJSON()
		{
			try
			{
				StreamReader r = new StreamReader("jurnal6_3_1302204081.json");
				string jsonString = r.ReadToEnd();
				JObject parsed = JObject.Parse(jsonString);

				//akses glossary
				var glossary = parsed["glossary"];
				//akses glossdiv dalam glossary
				var glossDiv = glossary["GlossDiv"];
				//akses glosslist dalam glossdiv
				var glossList = glossDiv["GlossList"];
				//akses gloss entry dalam gloss list
				var glossEntry = glossList["GlossEntry"];
				//akses setiap isi dalam glosslist
				var glossDef = glossEntry["GlossDef"];

				Console.WriteLine("ID: {0} \nSortAs: {1} GlossTerm: {2} \nAcronym: {3}\nAbbrev: " +
								  "{4} \nGlossDefPara: {5} \nGlossDefSee: 1. {6} 2. {7}  \nGlossSee: {8}"
									,
								  glossEntry["ID"], glossEntry["SortAs"], glossEntry["GlossTerm"], glossEntry["Acronym"], glossEntry["Abbrev"],
								  glossDef["para"], glossDef["GlossSeeAlso"][0], glossDef["GlossSeeAlso"][1],
								  glossEntry["GlossSee"]);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());	
			}
		}
	}
}
