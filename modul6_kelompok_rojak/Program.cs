using System;

namespace modul6_kelompok_rojak
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302204081 kevin = new DataMahasiswa_1302204081();
            kevin.readJson();
            TeamMembers_1302204081 member = new TeamMembers_1302204081();
            member.readJson();
            GlossaryItem_1302204081 glossaryItem = new GlossaryItem_1302204081();
            glossaryItem.readJSON();
        }
    }
}