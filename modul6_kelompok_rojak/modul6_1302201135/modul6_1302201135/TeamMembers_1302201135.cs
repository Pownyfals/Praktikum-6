using System;
using System.Text.Json;
using System.IO;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace modul6_1302201135
{
	public class TeamMembers
	{
		public void ReadJSON()
		{
			StreamReader ismi = new StreamReader("jurnal6_2_1302201135.json");
			string jsonString = ismi.ReadToEnd();
			JObject parsed = JObject.Parse(jsonString);

			var members = parsed["members"];
			var members0 = members[0];
			var members1 = members[1];
			var members2 = members[2];
			var members3 = members[3];

			Console.WriteLine("Team member list : ");
			Console.WriteLine(members0["nim"] + " " + members0["firstName"] + " " + members0["lastName"] + " " + members0["age"] + " " + members0["gender"]);
			Console.WriteLine(members1["nim"] + " " + members1["firstName"] + " " + members1["lastName"] + " " + members1["age"] + " " + members1["gender"]);
			Console.WriteLine(members2["nim"] + " " + members2["firstName"] + " " + members2["lastName"] + " " + members2["age"] + " " + members2["gender"]);
			Console.WriteLine(members3["nim"] + " " + members3["firstName"] + " " + members3["lastName"] + " " + members3["age"] + " " + members3["gender"]);
		}
	}
}