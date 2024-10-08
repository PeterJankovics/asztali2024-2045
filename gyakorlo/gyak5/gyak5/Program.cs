// szoveggenerator

StreamReader olvas1 = new StreamReader("alany.txt");
StreamReader olvas2 = new StreamReader("allitmany.txt");
StreamReader olvas3 = new StreamReader("helyhat.txt");

List<string> lista1 = new List<string>();
List<string> lista2 = new List<string>();
List<string> lista3 = new List<string>();

while (!olvas1.EndOfStream)
{
    lista1.Add(olvas1.ReadLine());
}
while (!olvas2.EndOfStream)
{
    lista2.Add(olvas2.ReadLine());
}
while (!olvas3.EndOfStream)
{
    lista3.Add(olvas3.ReadLine());
}
 
olvas1.Close();
olvas2.Close();
olvas3.Close();

Random random = new Random();

StreamWriter hozzaad = new StreamWriter("mondatok");




for (int i = 0; i < 100; i++)
{
    int valami1 = random.Next(lista1.Count);
    int valami2 = random.Next(lista2.Count);
    int valami3 = random.Next(lista3.Count);
    hozzaad.WriteLine(lista1[valami1] + " " + lista2[valami2] + " " + lista3[valami3] + ".");

    
}

hozzaad.Close();

