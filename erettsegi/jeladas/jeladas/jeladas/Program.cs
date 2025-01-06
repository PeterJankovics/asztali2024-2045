StreamReader olvas = new StreamReader("jeladas.txt");
List<string> adatok = new List<string>();



List<string> rendszam = new List<string>();
List<int> ora = new List<int>();
List<int> perc = new List<int>();
List<int> sebesseg = new List<int>();

while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    string[] vag = sor.Split(" ");
    adatok.Add(vag[0]);
    rendszam.Add(vag[1]);
    


}


while (!olvas.EndOfStream)
{
    string sor1 = olvas.ReadLine();
    string[] vag1 = sor1.Split("\t");
    ora.Add(Convert.ToInt32(vag1[2]));
    perc.Add(Convert.ToInt32(vag1[3]));
    sebesseg.Add(Convert.ToInt32(vag1[4]));
}

olvas.Close();

for (int i = 0; i < adatok.Count; i++)
{
    Console.WriteLine(adatok[i]);
}



