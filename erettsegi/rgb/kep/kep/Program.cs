
using kep;

List<Pixel> pontok = new List<Pixel>();

StreamReader olvas = new StreamReader("kep-1.txt");
int x = 0;
int y = 0;

while (!olvas.EndOfStream)
{
    string line = olvas.ReadLine();
    string[] vag = line.Split(" ");
    x = 0;
    for (int i = 0; i < vag.Length; i+=3)
    {
        int r = int.Parse(vag[i]);
        int g = int.Parse(vag[i]+1);
        int b = int.Parse(vag[i+2]);

        pontok.Add(new Pixel(0, 0, new Szin(r, g, b)));
        x++;
    }
    y++;
}

olvas.Close();


Console.WriteLine("2. feladat:");
Console.WriteLine("Kérek egy képpont adatait: ");
Console.WriteLine("Sor: ");
int sor = int.Parse(Console.ReadLine());
Console.WriteLine("Oszlop: ");
int oszlop = int.Parse(Console.ReadLine());

var talalat = pontok.Where(pont => pont.x == oszlop && pont.y == sor);
Console.WriteLine("A keppont szine {0}", talalat.ToString());



