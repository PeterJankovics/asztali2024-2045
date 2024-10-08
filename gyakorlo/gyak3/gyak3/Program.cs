//vezeteknevek keresese 100db nev generalasa
//veletlen szeruen ugy hogy egy vagy ket keresztneve
//is lehet egy embernek az eredmenyeket fajlba kiirni


StreamReader beolvas = new StreamReader("nevek.txt");
StreamReader olvas = new StreamReader("kereszt.txt");


string[] vezetek = beolvas.ReadToEnd().Split("\n");
string[] kereszt = olvas.ReadToEnd().Split(",");


StreamWriter kesz = new StreamWriter("kesz.txt");
Random random = new Random();

for (int i = 0; i < vezetek.Length; i++)
{
    int esely = random.Next(0,100);
}
olvas.Close();
beolvas.Close();