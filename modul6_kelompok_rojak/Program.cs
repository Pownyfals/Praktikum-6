using System;
using System.Text.Json;
using System.Text.Json;
using System.IO;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace modul6_kelompok_rojak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302203120.readJson();

        }
    }

    public class DataMahasiswa_1302203120 
    {

        public static void readJson()
        {
            StreamReader r = new StreamReader("jurnal6_1_1302203120.json");
            string jsonString = r.ReadToEnd();
            JObject parsed = JObject.Parse(jsonString);

            var firstName = parsed["firstName"];
            var lastName = parsed["lastName"];
            var gender = parsed["gender"];
            var age = parsed["age"];
            var address = parsed["address"];
            var streetAddress = address["streetAddress"];
            var city = address["city"];
            var state = address["state"];
            var courses = parsed["courses"];
            var course1 = courses[0];
            var course2 = courses[1];

            Console.WriteLine("Nama : {0} {1}, Gender : {2}, Age : {3},\nStreetAdress : {4}, City : {5}, State : {6}, " +
                "\nCourse 1 : {7} -> {8}, Course 2 : {9} -> {10}.", 
            firstName, lastName, gender, age, streetAddress, city, state, course1["code"], course1["name"], course2["code"], course2["name"]);

        }
        

        
    
    }

}