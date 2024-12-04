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
Console.WriteLine(szavakSzama);