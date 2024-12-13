using System.Text.RegularExpressions;

string adatok = File.ReadAllText("generated_log_2024-12-11T11_21_39.997Z (1).txt");



Regex Minta = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");


var talalat = Minta.Matches(adatok);
//Console.WriteLine(talalat);

//Console.WriteLine(talalat.Count);

var kereses = "GET";

//Regex Minta2 = new Regex(@"^(\a[g]\a[e]\a[t])");

var pattern = Regex.Escape(kereses);

var vegeredmeny = Regex.Matches(adatok, pattern);
//Console.WriteLine(vegeredmeny.Count);



Regex minta2 = new Regex(@"GET (/\s*)");

var talalat2 = minta2.Matches(adatok);

Console.WriteLine(talalat2.Count);



//var talalat2 = Minta.Matches(adatok);
//Console.WriteLine(talalat2.Count);

Regex minta3 = new Regex(@"\S{3} (\d|\d{2}) \d{4}");

var talalat3 = minta3.Matches(adatok);

Console.WriteLine(talalat3.Count);
/*
foreach (Match elem in talalat3)
{
    Console.WriteLine(elem.Groups[1].Value);
}
*/
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
