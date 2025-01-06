using System.Security.Authentication;

StreamReader olvas = new StreamReader("SuperBowl.txt");

Console.WriteLine(olvas);

List<string> adatok = new List<string>();



List<string> ssz = new List<string>();
List<int> datum = new List<int>();
List<string> gyoztes = new List<string>();
List<int> eredmeny = new List<int>();
List<string> vesztes = new List<string>();
List<string> helyszin = new List<string>();
List<string> varosallam = new List<string>();
List<int> nezoszam = new List<int>();

while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    string[] vag = sor.Split(";");
    adatok.Add(vag[0]);
    ssz.Add(vag[1]);
    datum.Add(Convert.ToInt32(vag[2]));
    gyoztes.Add(vag[3]);
    eredmeny.Add(Convert.ToInt32(vag[4]));
    vesztes.Add(vag[5]);
    helyszin.Add(vag[6]);
    varosallam.Add(vag[7]);
    nezoszam.Add(Convert.ToInt32(vag[8]));


}
/*
foreach (string sor in adatok.Skip(1))
{
    Console.WriteLine(sor);
}
*/
olvas.Close();

