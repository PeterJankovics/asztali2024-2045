using System.Security.Cryptography.X509Certificates;

StreamReader beolvas = new StreamReader("nevek.txt");


string[] nevek = beolvas.ReadToEnd().Split(";");

foreach (string i in nevek)
{
    Console.WriteLine(i);
}

beolvas.Close();
