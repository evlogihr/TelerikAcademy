using System;

class P03
{
    static void Main()
    {
        Console.Write("enter expression with barckets: ");
        string input = Console.ReadLine();

        int openingCount = 0;
        int closeingCount = 0;
        for (int indexOpening = -1; (indexOpening = input.IndexOf("(", indexOpening + 1)) != -1; )
        {
            openingCount++;
        }

        for (int indexCloseing = -1; (indexCloseing = input.IndexOf(")", indexCloseing + 1)) != -1; )
        {
            closeingCount++;
        }

        if (openingCount == closeingCount)
        {
            Console.WriteLine("the expression is correct");
        }
        else
        {
            Console.WriteLine("the expression is incorrect");
        }
    }
}