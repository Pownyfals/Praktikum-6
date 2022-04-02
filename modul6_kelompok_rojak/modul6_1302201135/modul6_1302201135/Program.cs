using System;
using System.Text.Json;
using System.IO;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace modul6_1302201135
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa data = new DataMahasiswa();
            data.ReadJSON();
            Console.WriteLine();

            TeamMembers dataTeam = new TeamMembers();
            dataTeam.ReadJSON();
            Console.WriteLine();

        }
    }
}