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
            Console.WriteLine("");
            TeamMembers_1302203120.readJson();

        }
    }


}