using System;

class PrintNums1ToN
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("n = ");
        } while (!int.TryParse(Console.ReadLine(), out n));
        int number = 0;
        while (number < n)
        {
            number++;
            Console.WriteLine(number);
        }
    }
}