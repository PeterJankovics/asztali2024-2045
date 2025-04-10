using Nyelvvizsga;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;



List<Nyelvadat> sikeresek = new List<Nyelvadat>();
List<Nyelvadat> sikertelen = new List<Nyelvadat>();

sikeresek = fajlBetolt("sikeres.csv");

static List<Nyelvadat> fajlBetolt(string fileName)
{

    List<Nyelvadat> adatok = new List<Nyelvadat>();

    StreamReader olvas = new StreamReader(fileName);

    string sor = olvas.ReadLine();
    string[] vag = .Split(";");
    int[] evszamok = new int[vag.Length - 1];


    while (!olvas.EndOfStream)
    {
        
        
    }
    
    olvas.Close();

    return adatok;

}