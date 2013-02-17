using System;

class Problem01
{

    static void Main()
    {
        Console.Write("enter a number: ");
        int num = int.Parse(Console.ReadLine());

        string binary = "";
        while (num > 0)
        {
            binary = (num % 2).ToString() + binary;
            num /= 2;
        }

        Console.WriteLine("it's binary representation: {0}", binary);
    }
}
