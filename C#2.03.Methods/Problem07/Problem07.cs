using System;

class Problem07
{
    static int ReverceDigits(int num)
    {
        int revNumber = 0;
        while (num > 0)
        {
            revNumber = revNumber * 10 + num % 10;
            num /= 10;
        }
        return revNumber;
    }

    static void Main()
    {
        Console.Write("enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("the number with reverced digits is: {0}", ReverceDigits(num));
    }
}
