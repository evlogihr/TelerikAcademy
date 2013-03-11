using System;

class CatalanNumbers
{
    static void Main()
    {
        uint n;
        string consoleInput;
        do
        {
            Console.Write("Enter a positive number  N = ");
            consoleInput = Console.ReadLine();
        } while (!uint.TryParse(consoleInput, out n));
        uint nDoubleFactorial = 1;
        uint nPlusOneFactorial = 1;
        uint nFactorial = 1;
        for (uint i = 1; i <= n; i++)
        {
            nDoubleFactorial *= (2 * i) * (2 * i - 1);
            nPlusOneFactorial *= i + 1;
            nFactorial *= i;
        }
        double catalan = (double)nDoubleFactorial / (double)(nPlusOneFactorial * nFactorial);
        Console.WriteLine(catalan);
    }
}
