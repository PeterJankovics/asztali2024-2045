Console.WriteLine("szamod: ");

string szam = Console.ReadLine();
Console.WriteLine("szamod: " + Int32.Parse(szam));

while (Int32.Parse(szam) != 0)
{

    int szam1 = Int32.Parse(szam) * Int32.Parse(szam);

    StreamWriter filebair = new StreamWriter(Convert.ToString(szam1));


    filebair.Close();
}
