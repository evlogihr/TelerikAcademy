using System;

class Problem11
{
    static void SumPolynom(int[] polyOne, int[] polyTwo)
    {
        if (polyOne.Length > polyTwo.Length)
        {
            for (int i = 0; i < polyTwo.Length; i++)
            {
                polyOne[i] += polyTwo[i];
            }
            PrintPolynom(polyOne);
        }
        else
        {
            for (int i = 0; i < polyOne.Length; i++)
            {
                polyTwo[i] += polyOne[i];
            }
            Console.Write("sum: ");
            PrintPolynom(polyTwo);
        }
    }

    static void PrintPolynom(int[] polynom)
    {
        for (int i = polynom.Length - 1; i > -1; i--)
        {
            if (polynom[i] != 0)
            {
                Console.Write("{0}", polynom[i]);
                if (i > 0)
                {
                    Console.Write("x");
                    if (i > 1)
                    {
                        Console.Write("^{0} ", i);
                    }
                }
            }
            if (i > 0 && polynom[i - 1] > 0)
            {
                Console.Write(" +");
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] polyOne = { 3, 2, 0, 4 };
        Console.Write("polynom one: ");
        PrintPolynom(polyOne);
        int[] polyTwo = { 2, -5, 0, 2, -6 };
        Console.Write("polynom two: ");
        PrintPolynom(polyTwo);

        SumPolynom(polyOne, polyTwo);
    }
}
