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

				var glossaryEntry = parsed["glossaryEntry"];
				
				Console.WriteLine(glossaryEntry);
			}catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());	
			}
		}
	}
}
