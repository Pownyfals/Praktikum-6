using System;
using System.Text.Json;
using System.Text.Json;
using System.IO;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace modul6_kelompok_rojak

{
    public class Program
    {
        static void Main(string[] args)
        {
            //punya razqy
            DataMahasiswa_1302202072 r = new DataMahasiswa_1302202072();
            teamMembers_1302202072 t = new teamMembers_1302202072();
            t.readJson();
            GlossaryItem_1302202072 g = new GlossaryItem_1302202072();
            g.readJson();
            r.readJson();
            //punya kevin
            DataMahasiswa_1302204081 kevin = new DataMahasiswa_1302204081();
            kevin.readJson();
            TeamMembers_1302204081 member = new TeamMembers_1302204081();
            member.readJson();
            GlossaryItem_1302204081 glossaryItem = new GlossaryItem_1302204081();
            glossaryItem.readJSON();
            Console.WriteLine("==============================");
            //punya jek
            DataMahasiswa_1302203120.readJson();
            Console.WriteLine("");
            TeamMembers_1302203120.readJson();
            Console.WriteLine("");
            GlosarryItem_1302203120.readJson ();

        }
    }

}