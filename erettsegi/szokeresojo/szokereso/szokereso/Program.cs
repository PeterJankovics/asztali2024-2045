StreamReader olvas = new StreamReader("szavak.txt");
List<string> szavak = new List<string>();
List<int> x = new List<int>();
List<int> y = new List<int>();

while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    string[] vag = sor.Split("*");
    szavak.Add(vag[0]);
    x.Add(Convert.ToInt32(vag[1]));
    y.Add(Convert.ToInt32(vag[2]));

    
}
olvas.Close();

int szavakSzama = 0;
for (int i = 0; i < szavak.Count; i++)
{
    szavakSzama++;
}
List<string> leghosszabb = new List<string>();
int hossz = 0;
for (int i = 0; i < szavak.Count; i++)
{
    if (szavak[i].Length > hossz)
    {
        hossz = szavak[i].Length;
    }
}

for (int i = 0; i < szavak.Count; i++)
{
    if (szavak[i].Length == hossz)
    {
        leghosszabb.Add(szavak[i]);
    }
}



Console.WriteLine("2. Feladat: - Leghosszabb szó hossza: " + hossz + " db karakterből áll");
Console.WriteLine("1. Feladat: - Szavak száma: " + szavakSzama + " db");
Console.WriteLine("3. Feladat: - Leghosszabb szó/szavak: ");

for (int i = 0; i < leghosszabb.Count; i++)
{
    Console.WriteLine("\t" + leghosszabb[i]);
}

int[,] szamok = new int[16, 16];

