using System;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace modul6_1302201135
{
	public class DataMahasiswa
	{
		public void ReadJSON()
		{
			StreamReader ismi = new StreamReader("jurnal6_1_1302201135.json");
			string jsonString = ismi.ReadToEnd();
			JObject parsed = JObject.Parse(jsonString);

			var firstName = parsed["firstName"];
			var lastName = parsed["lastName"];
			var gender = parsed["gender"];
			var age = parsed["age"];
			var address = parsed["address"];
			var streetAddress = parsed["street"];
			var city = parsed["city"];
			var state = parsed["state"];
			var courses = parsed["courses"];
			var courses0 = courses[0];
			var courses1 = courses[1];

			Console.WriteLine("First Name : {0} \nLast Name : {1} \nGender : {2} \nAge : {3} \nAddress : {4}, {5}, {6}" +
				"\nCourses : {7} {8}", firstName, lastName, gender, age, streetAddress, city, state, courses0["name"], courses0["code"], courses1["name"], courses1["code"]);

		}
	}
}

