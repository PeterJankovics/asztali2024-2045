using belepteto;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;

List<Class1> esemenyek = new List<Class1>();

string[] sorok = File.ReadAllLines("bedat.txt");

for (int i = 0; i < sorok.Length; i++)
{
    esemenyek.Add(new Class1(sorok[i]));
}

Console.WriteLine("2. Feladat");
Console.WriteLine("Az első tanuló {0}-kor lépett be a főkapun.",esemenyek[0].ido);
Console.WriteLine("Az első tanuló {0}-kor lépett be a főkapun.", esemenyek[esemenyek.Count-1].ido);

Console.WriteLine("3. Feladat");
StreamWriter ir = new StreamWriter("kesok.txt");


for (int i = 0; i < esemenyek.Count; i++)
{
    if (((esemenyek[i].ora == 7 && esemenyek[i].perc >= 50)
        || (esemenyek[i].ora == 7 && esemenyek[i].perc >= 50)
        )
        &&
        (esemenyek[i].esemeny == 1))
    {
        ir.WriteLine(esemenyek[i].ido + " " + esemenyek[i].kod);
    }

}
ir.Close();

Console.WriteLine("4. Feladat");


int ebedlo = 0;

for (int i = 0; i < esemenyek.Count; i++)
{
    if (esemenyek[i].esemeny == 3)
    {
        ebedlo++;
    }
}

Console.WriteLine($" A menzán aznap {ebedlo} tanuló ebédelt.");

Console.WriteLine("5. Feladat");

HashSet<string> konvtarLatogatok = new HashSet<string>();

for (int i = 0; i < esemenyek.Count; i++)
{
    if (esemenyek[i].esemeny == 4)
    {
        konvtarLatogatok.Add(esemenyek[i].kod);
    }
    
}
if (konvtarLatogatok.Count > ebedlo)
{
    Console.WriteLine("Tobben voltak menzean.");
}
else
{
    Console.WriteLine("Nem voltak tobben menzean.");
}
HashSet<string> kodok = new HashSet<string>();

for (int i = 0; i < esemenyek.Count; i++)
{
    kodok.Add(esemenyek[i].kod);

}

Console.WriteLine("6. Feladat");
Console.WriteLine("");

foreach (string egykod in kodok)
{
    
    for(int i = 0;i < esemenyek.Count;i++)
    {
        bool bentVan = false;
        if (esemenyek[i].kod == egykod)
        {
            if (esemenyek[i].esemeny == 1)
            {
                if (bentVan)
                {
                    if (esemenyek[i].ora == 10 && esemenyek[i].perc >= 50)
                    Console.WriteLine(egykod + "");
                }
                else
                {
                    bentVan = true;
                }
            }
            else if (esemenyek[i].esemeny == 2)
            {
                bentVan = false;
            }
        }

    }
}


Console.WriteLine("7. Felatad");
Console.WriteLine("Egy tanulo azonositoja szerepel");

string tanuloKod = Console.ReadLine();
Class1 elso = new Class1("0:0");
Class1 utolso;
for (int i = 0; i < esemenyek.Count; i++)
{
    
}

