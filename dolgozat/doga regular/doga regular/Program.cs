using System.Globalization;
using System.Text.RegularExpressions;

string adatok = File.ReadAllText("generated_log_2024-12-16T09_53_52.397Z.txt");


Regex minta = new Regex(@"POST (/\s*)");

var talalat = minta.Matches(adatok);

Console.WriteLine(talalat.Count);


Regex minta2 = new Regex(@"(DELETE) /(\S+) (\S+)\u0022");


var talalat2 = minta2.Matches(adatok);

Console.WriteLine("Torles: "+talalat2.Count);




Regex minta3 = new Regex(@"\/(\S+) HTTP\/\d+\.\d+");

var talalat3 = minta3.Matches(adatok);

//Console.WriteLine(talalat3.Count +"---------------");




Dictionary<string, int> kigyujt = new Dictionary<string, int>();


foreach (Match elem in talalat3)
{
    if (kigyujt.ContainsKey(elem.Value))
    {
        kigyujt[elem.Value]++;
    }
    else
    {
        kigyujt.Add(elem.Value, 1);
    }
}



foreach (KeyValuePair<string, int> elem in kigyujt)
{
    Console.WriteLine(elem);
}


int legtobb2 = kigyujt.Max(elem => elem.Value);
var legtobb1 = kigyujt.Keys.Max();

Console.WriteLine("-------------------");


Console.WriteLine(legtobb1 +"\t" + legtobb2);








Regex minta4 = new Regex(@"[A-Z][a-z]+\/+\S+\u0022");

var talalat4 = minta4.Matches(adatok);

//Console.WriteLine(talalat4.Count);
Console.WriteLine("--------------");

Dictionary<string, int> kigyujt4 = new Dictionary<string, int>();


foreach (Match elem in talalat4)
{
    if (kigyujt4.ContainsKey(elem.Value))
    {
        kigyujt4[elem.Value]++;
    }
    else
    {
        kigyujt4.Add(elem.Value, 1);
    }
}

foreach (KeyValuePair<string, int> elem in kigyujt4)
{
    Console.WriteLine(elem);
}



Regex minta5 = new Regex(@"\u0022\-\u0022");

var talalat5 = minta3.Matches(adatok);

Console.WriteLine(talalat5.Count);


Console.WriteLine("--------------");





using (StreamWriter ir = new StreamWriter("noreferer.log"))
{
    foreach (DirectoryInfo elem in talalat5)
    {
        ir.WriteLine(elem.Name);
    }
}








