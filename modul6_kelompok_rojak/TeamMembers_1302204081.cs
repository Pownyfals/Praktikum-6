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
	internal class TeamMembers_1302204081
	{
		public void readJson()
		{
			try
			{

				StreamReader r = new StreamReader("jurnal6_2_1302204081.json");
				string jsonString = r.ReadToEnd();
				JObject parsed = JObject.Parse(jsonString);

				Console.WriteLine(" ");
				var members = parsed["members"];
				Console.WriteLine("Member Tim Rojak Squad");
				foreach (var item in members)
				{
					Console.WriteLine("Nama depan : {0}", item["firstName"]);
					Console.WriteLine("Nama belakang : {0}",item["lastName"]);
					Console.WriteLine("Gender : {0}",item["gender"]);
					Console.WriteLine("Umur : {0}",item["age"]);
					Console.WriteLine("NIM : {0}",item["nim"]);
					Console.WriteLine(" ");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
