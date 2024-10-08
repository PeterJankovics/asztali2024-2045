Random random = new Random();

int fok = random.Next(10, 40); ;
Console.WriteLine(fok + "d");
int orankenti = 0;
for (int i = 0; i < 1; i++)
{
    orankenti = random.Next(fok - 5, fok + 5);
    for (int k = 0; k < 24; k++)
    {
        orankenti = random.Next(orankenti - 5, orankenti +5);
        if (orankenti <= 10 || orankenti >= 40)
        {
            while (!(orankenti <= 10 || orankenti >= 40))
            {
                orankenti = random.Next(orankenti - 5, orankenti + 5);
            }
        }
        
        Console.WriteLine(orankenti);
    }
}
    
