using System.Numerics;

static BigInteger fact(int szam)
{
    BigInteger eredmeny = 1;
    if (szam > 1)
    {
        eredmeny = fact(szam - 1);
    }
    else
    {
        return 1;
    }
    return szam * eredmeny;
}


Console.WriteLine(fact(10000));
