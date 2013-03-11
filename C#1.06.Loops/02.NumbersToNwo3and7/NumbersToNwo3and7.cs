using System;

class NumbersToNwo3and7
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
            if (number % 3 == 0 || number % 7 == 0)
            {
                continue;
            }
            Console.WriteLine(number);
        }
    }
}