using System.Security.Cryptography;
using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;

static int szambekeres(int min = 3, int max = 15)
{
    int szam = 0;
    while (szam == 0)
    {
        Console.WriteLine("Kerek egy szamot {0} es {1} kozott: ", min, max);
        {
            
        }
        try
        {
            szam = Convert.ToInt32(Console.ReadLine());
            if (szam < min || szam > max)
            {
                throw new Exception();
            }
        }
        catch
        {
            szam = 0;
            Console.WriteLine("Ez nem egy szam");
        }
    }
    return szam;

}

szambekeres();

static string szogeneralas(int hossz)
{
    string[] betuk = {"euioöüóőúaéáűí", "qwrtzpsdfghjklyxcvbnm"};
    Random random = new Random();
    int melyikjon = random.Next(2);

    string vissza = "";
    for (int i = 0; i < hossz; i++)
    {
        vissza += betuk[melyikjon][random.Next(betuk[melyikjon].Length)];
        melyikjon = 1 - melyikjon;
        
    }
    return vissza;
}



static List<string> sokszo(int hossz, int darab = 200)
{
    List<string> szavak = new List<string>();
    for (int i = 0; i < darab; i++)
    {
        szavak.Add(szogeneralas(hossz));
    }
    return szavak;
}



static void filebair(List<string> szavak)
{
    StreamWriter ir = new StreamWriter("sok.txt");
    for (int i = 0;i < szavak.Count;i++)
        ir.WriteLine(szavak[i]);

    ir.Close();
}

int betuszam = szambekeres(5, 10);
Console.WriteLine(szogeneralas(6));
List<string> szavak = sokszo(betuszam);
filebair(szavak);



static List<string> mondatok(List<string> szavak)
{
    Random random = new Random();
    List<string> mondatok = new List<string>();
    for(int i = 0; i <= szavak.Count;i++)
    {
        
    }
}