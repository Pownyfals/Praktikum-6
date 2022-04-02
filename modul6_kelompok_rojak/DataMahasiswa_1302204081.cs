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
    public class DataMahasiswa_1302204081
    {

        public void readJson()
        {
			try
			{
                StreamReader r = new StreamReader("jurnal6_1_1302204081.json");
                string jsonString = r.ReadToEnd();
                JObject parsed = JObject.Parse(jsonString);


                Console.WriteLine("Nama: {0} {1}", parsed["firstName"], parsed["lastName"]); ;
                Console.WriteLine("Jenis Kelamin: {0}", parsed["gender"]);
                Console.WriteLine("Umur: {0}", parsed["age"]);
                //parsing object 
                var address = parsed["address"];
                Console.WriteLine("alamat:");
                Console.WriteLine("Jalan: {0}", address["streetAddress"]);
                Console.WriteLine("Kota: {0}", address["city"]);
                Console.WriteLine("Provinsi: {0}", address["state"]);
                    Console.WriteLine(" ");
                //parsing list mk
                var mk = parsed["courses"];
                Console.WriteLine("Matakuliah yang diambil :");
                foreach (var item in mk)
                {
                    Console.WriteLine("{0}  {1}", item["code"], item["name"]);
                }
			}catch(Exception ex)
			{
                Console.Write(ex.Message);
			}

        }
    }
}