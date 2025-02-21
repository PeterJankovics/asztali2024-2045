using System.ComponentModel.Design;
using tanciskola;

List<Adatok> adatok = new List<Adatok>();

StreamReader olvas = new StreamReader("tancrend.txt");


while (!olvas.EndOfStream)
{
    adatok.Add(new Adatok(olvas.ReadLine(), 
        olvas.ReadLine(), 
        olvas.ReadLine()));
}


olvas.Close();



Console.WriteLine($"2. Feladat:\t Az elso: {adatok.First()}, Az utolso tanc: {adatok.Last()}.");

Console.WriteLine($"3. Feladat:\t {adatok.Where(tanc => tanc.tanc == "samba").Count()}");



Console.WriteLine($"4. Feladat:\t Vilma ezekben a tancokban szerepelt: " +
    $"{string.Join("; ", adatok.Where(vilma => vilma.lany == "Vilma").Select(vilma => vilma.tanc))}");


Console.WriteLine("5. Feladat:\t Kerek egy lanynevet: ");
string bekeres = olvas.ReadLine();

if (adatok.Where(beker => beker.tanc == bekeres && vilma => vilma.lany == "Vilma").Count()) != 0;
{
    Console.WriteLine($"A {bekeres} bemutatóján Vilma Párja {adatok.Select(fiu => fiu.fiu)}");
}
else
{
    Console.WriteLine($"Vilma nem táncolt {bekeres}");
}
/*
adatok.Where(beker => beker.tanc = bekeres);
{
    Console.WriteLine("asdasd");
}

*/



StreamWriter iras = new StreamWriter("szereplok.txt");

//iras.WriteLine($"Lányok: {string.Join(", ", adatok.Where(nev => nev.lany))}");
iras.WriteLine($"Lányok: {string.Join(", ", adatok.Select(nev => nev.lany))}");
iras.WriteLine($"Fiúk: {string.Join(", ", adatok.Select(nev => nev.fiu))}");


iras.Close();



