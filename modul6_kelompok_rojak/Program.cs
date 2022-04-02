using System;

namespace modul6_kelompok_rojak 
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302202072 r = new DataMahasiswa_1302202072();
            r.readJson();

            teamMembers_1302202072 t = new teamMembers_1302202072();
            t.readJson();

            GlossaryItem_1302202072 g = new GlossaryItem_1302202072();  
            g.readJson();
        }
    }
}