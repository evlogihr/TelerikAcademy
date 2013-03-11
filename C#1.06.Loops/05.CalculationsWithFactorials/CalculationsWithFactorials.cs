using System;
using System.Numerics;

class CalculationsWithFactorials
{
    static void Main()
    {
        Console.Write("N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int K = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger knFactorial = 1;
        for (int i = 1; i <= K; i++)
        {
            kFactorial *= i;
        }
        for (int i = 1; i <= N; i++)
        {
            nFactorial *= i;
        }
        for (int i = 1; i <= (K - N); i++)
        {
            knFactorial *= i;
        }
        Console.WriteLine("N!*K!/(K-N)! = {0}", (nFactorial * kFactorial) / knFactorial);
    }
}