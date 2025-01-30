using park;

List<adatok> viragok = new List<adatok>();

string[] sorok = File.ReadAllLines("felajanlas.txt");


foreach (string s in sorok.Skip(1))
{
    viragok.Add(new adatok(s));
}

