using System;

namespace modul6_kelompok_rojak
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302204081 kevin = new DataMahasiswa_1302204081();
            kevin.readJson();
            TeamMembers_1302204081 m = new TeamMembers_1302204081();
            m.readJson();
        }
    }
}