using System.Text.RegularExpressions;

string adatok = File.ReadAllText("generated_log_2024-12-11T11_21_39.997Z (1).txt");



Regex Minta = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");


var talalat = Minta.Matches(adatok);
//Console.WriteLine(talalat);

Console.WriteLine(talalat.Count);
