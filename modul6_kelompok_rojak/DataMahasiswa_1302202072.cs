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
    public class DataMahasiswa_1302202072
    {

        public void readJson()
        {
            StreamReader r = new StreamReader("jurnal6_1_1302202072.json");
            string jsonString = r.ReadToEnd();
            JObject parsed = JObject.Parse(jsonString);


            Console.WriteLine("Nama\t: {0} {1}", parsed["firstName"], parsed["lastName"]); ;
            Console.WriteLine("Kelamin\t: {0}", parsed["gender"]);
            Console.WriteLine("Umur\t: {0}", parsed["age"]);

            var alamat = parsed["address"];
            Console.WriteLine("alamat:");
            Console.WriteLine("\tJalan\t\t: {0}", alamat["streetAddress"]);
            Console.WriteLine("\tKota\t\t: {0}", alamat["city"]);
            Console.WriteLine("\tProvinsi\t: {0}", alamat["state"]);

            var mk = parsed["courses"];
            Console.WriteLine("Matakuliah yang diambil :");
            foreach (var item in mk)
            {
                Console.WriteLine("\t{0}-{1}", item["code"], item["name"]);

            }










        }
    }
}
