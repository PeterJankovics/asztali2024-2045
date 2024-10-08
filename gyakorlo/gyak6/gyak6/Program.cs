// 15 bekezdes a mondatok kulon sorban legyenek.
// Kesziteni egy fuggvenyt ami ezt a filet beolvassa egy lisataba és ezt visszaadja ertekkent.
// Kesziteni egy fuggveny ami megkepja a listat es vegrehajt egy muveletet, minden elemen(mondaat).
// Egy fuggveny a muvelet ami megkapja a sort es megkap egy
// szamot hogy a mondat hanyadik szavat kell visszaadnia(lehet egy random szam is vagy megadott szam).
// Ezeket a szavakat osszegyujteni egy lisataba es ezt a listat adja vissza az a fuggveny.




//StreamReader beolvas = new StreamReader("mondatok.txt");

static List<string> f1()
{
    List<string> mondatok = new List<string>();
    StreamReader beolvas = new StreamReader("mondatok.txt");
    while (!beolvas.EndOfStream)
    {
        mondatok.Add(beolvas.ReadLine());
    }
    beolvas.Close();
    return mondatok;
}

List<string> mondatok = f1();

for (int i = 0; i < mondatok.Count; i++)
{
    Console.WriteLine(mondatok[i]);
}

