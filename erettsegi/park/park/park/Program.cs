using park;
using System.Diagnostics;
using System.Globalization;

List<adatok> viragok = new List<adatok>();

string[] sorok = File.ReadAllLines("felajanlas.txt");


foreach (string s in sorok.Skip(1))
{
    viragok.Add(new adatok(s));
}

for (int i = 0; i < sorok.Length; i++)
{
    
}

//LinkQ

viragok = sorok.Skip(1).Select(sor => new adatok(sor)).ToList();


Console.WriteLine("2.feladat: A felajanlasunk szama: {0}", viragok.Count);

Console.WriteLine("3. fealadat: A bejarat mindket oldalan ultetok: ");


Console.Write("4. feladat:\n Adja meg az agyas sorszamat: ");

int be = int.Parse(Console.ReadLine());
int darab = 0;

string szin = "";

HashSet<string> szinek = new HashSet<string>();


for (int i = 0; be > 0; i++)
{
    if (viragok[i].bennevanez(be))
    {
        darab++;
        if (szin == "")
        {
            szin = viragok[i].szin;
        }
        szinek.Add(szin);
         
    }
}

Console.WriteLine("A felajanlok szama: {0}", darab);

if (darab != 0)
{
    Console.WriteLine("Ezt az agyast nem ultetik be");
}
else 
{
    Console.WriteLine("A viragagyas szinei: {0}",
    string.Join(" ", szinek));
}

List<adatok> szurt = viragok
    .Where(
    elem => elem.bennevanez(be)).ToList();

Console.WriteLine("A felajanlok szama: {0}", szurt.Count);


List<adatok>[] agyasok2 = new List<adatok>[darab+1];
for (int i = 1; i < darab + 1; i++)
{
    for (int j = 1; j < viragok.Count + 1; j++)
    {
        if (viragok[j].bennevanez(i))
        {
            agyasok2[i].Add(viragok[j]);
        }
    }
}

