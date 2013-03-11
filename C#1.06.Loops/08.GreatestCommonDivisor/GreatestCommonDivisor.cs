using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers: ");
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        int divisor = Math.Min(numOne, numTwo);
        int rest = Math.Max(numOne, numTwo);
        do
        {
            int temp = divisor;
            divisor = rest % divisor;
            rest = temp;
        } while (rest % divisor == 0);
        Console.WriteLine("GCD: {0}", (rest % divisor));
    }
}
