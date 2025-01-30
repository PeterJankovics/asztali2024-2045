

using System.ComponentModel.Design;

for (int i = 0; i < 20; i++)
{
    Console.WriteLine(Fib(20-i)+ " ");
}


static int Fib(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else if (n == 1)
    {
        return 1;
    }
    else
    {
        return Fib(n-1) + Fib(n-2);
    }

}



static int Act(int N, int M)
{
    switch (N)
    {
        case 0: return M + 1; break;
        default:
            if (N == 0 && M == 0)
            {
                return Act(N - 1, 1);
            }
            else
            {
                return Act(N - 1, M);

            }

    }
}