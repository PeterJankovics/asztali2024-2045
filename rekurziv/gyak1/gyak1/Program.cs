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

static void Quick(int[] A, int E, int V)

{
    
    int K = 0;
    Szetvalogat(A, E, V, K);
    if (K - E > 1) { Quick(A, E, K - 1);}
    if (V - K > 1) { Quick(A, K + 1, V);}

}

static void Szetvalogat(int[] A, int E, int V, int K)
{
    int X;
    int L;
    K = E;
    L = V;
    X = A[K];
    while (K > L)
    {

        while (K < L && A[K] > X)
        {
            L--;
        }
        if (K < L)
        {
            A[K] = A[L];
            K++;
            while (K < L && A[K] <= X)
            {
                K++;
            }
            if (K > L)
            {
                A[L] = A[K];
                L--;
            }
        }
    }
    A[K] = X;

}



int[] szamok = [5, 3, 8, 3, 4, 10, 8, 63, 4, 5];
Console.WriteLine(szamok);
Quick(szamok, 0, szamok.Length- 1);

