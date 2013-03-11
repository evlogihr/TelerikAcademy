using System;

class FractalFractionalSum
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        long x = long.Parse(Console.ReadLine());
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            long factorial = 1;
            long xn = 1;
            factorial *= i;
            for (int j = 0; j < i; j++)
            {
                xn *= x;
            }
            sum += (double)factorial/xn;
        }
        Console.WriteLine(sum);
    }
}