using System;
using System.Numerics;

class DivideFactorials
{
    static void Main()
    {
        Console.Write("N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int K = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        for (int i = 1; i <= K; i++)
        {
            kFactorial *= i;
        }
        for (int i = 1; i <= N; i++)
        {
            nFactorial *= i;
        }
        Console.WriteLine("N!/K! = {0}",nFactorial/kFactorial);
    }
}
