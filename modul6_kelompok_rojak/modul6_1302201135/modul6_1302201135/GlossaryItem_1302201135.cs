using System;
using System.Text.Json;
using System.IO;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class GlossaryItem
{
	public void ReadJSON()
	{
        StreamReader ismi = new StreamReader("jurnal6_3_1302203120.json");
        string jsonString = ismi.ReadToEnd();
        JObject parsed = JObject.Parse(jsonString);

        var glossary = parsed["glossary"];
        var glossDiv = parsed["GlossDiv"];
        var glossList = parsed["GlossList"];
        var glossEntry = parsed["GlossEntry"];
        var glossDef = parsed["GlossDef"];

        Console.WriteLine("ID: {0} \nSortAs: {1} \nGlossTerm: {2} \n" +
                          "Acronym: {3} \nAbbrev: {4} \nGlossDef-para: {5} \nGlossDef-see: 1. {6} 2. {7} \n" +
                          "GlossSee: {8})", glossEntry["ID"], glossEntry["SortAs"], glossEntry["GlossTerm"], glossEntry["Acronym"], glossEntry["Abbrev"], glossDef["para"], glossDef["GlossSeeAlso"][0], glossDef["GlossSeeAlso"][1], glossEntry["GlossSee"]);
    }
}
