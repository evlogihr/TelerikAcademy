using System;

class Problem12
{
    static void SumPolynom(int[] polyOne, int[] polyTwo)
    {
        if (polyOne.Length > polyTwo.Length)
        {
            int[] polyRes = new int[polyOne.Length];
            for (int i = 0; i < polyOne.Length; i++)
            {
                polyRes[i] += polyOne[i];
            }
            for (int i = 0; i < polyTwo.Length; i++)
            {
                polyRes[i] += polyTwo[i];
            }
            Console.Write("sum: ");
            PrintPolynom(polyRes);
        }
        else
        {
            int[] polyRes = new int[polyTwo.Length];
            for (int i = 0; i < polyOne.Length; i++)
            {
                polyRes[i] += polyOne[i];
            }
            for (int i = 0; i < polyTwo.Length; i++)
            {
                polyRes[i] += polyTwo[i];
            }
            Console.Write("sum: ");
            PrintPolynom(polyRes);
        }
    }

    static void SubPolynom(int[] polyOne, int[] polyTwo)
    {
        if (polyOne.Length > polyTwo.Length)
        {
            int[] polyRes = new int[polyOne.Length];
            for (int i = 0; i < polyOne.Length; i++)
            {
                polyRes[i] += polyOne[i];
            }
            for (int i = 0; i < polyTwo.Length; i++)
            {
                polyRes[i] -= polyTwo[i];
            }
            Console.Write("subtraction: ");
            PrintPolynom(polyRes);
        }
        else
        {
            int[] polyRes = new int[polyTwo.Length];
            for (int i = 0; i < polyOne.Length; i++)
            {
                polyRes[i] += polyOne[i];
            }
            for (int i = 0; i < polyTwo.Length; i++)
            {
                polyRes[i] -= polyTwo[i];
            }
            Console.Write("subtraction: ");
            PrintPolynom(polyRes);
        }
    }

    static void MultiplyPolynom(int[] polyOne, int[] polyTwo)
    {

        int[] polyRes = new int[polyOne.Length + polyTwo.Length - 1];
        for (int i = 0; i < polyOne.Length; i++)
        {
            for (int j = 0; j < polyTwo.Length; j++)
            {
                polyRes[i + j] += polyOne[i] * polyTwo[j];
            }
        }
        Console.Write("multiplication: ");
        PrintPolynom(polyRes);
    }

    static void PrintPolynom(int[] polynom)
    {
        for (int i = polynom.Length - 1; i > -1; i--)
        {
            if (polynom[i] != 0)
            {
                Console.Write(" {0}", polynom[i]);
                if (i > 0)
                {
                    Console.Write("x");
                    if (i > 1)
                    {
                        Console.Write("^{0}", i);
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
        int[] polyOne = { 2, 1, 3 }; //{ 3, 2, 0, 4 };
        Console.Write("polynom one: ");
        PrintPolynom(polyOne);
        int[] polyTwo = { 5, 2, 2 }; //{ 2, -5, 0, 2, -6 };
        Console.Write("polynom two: ");
        PrintPolynom(polyTwo);

        SumPolynom(polyOne, polyTwo);
        SubPolynom(polyOne, polyTwo); //polyOne - polyTwo
        MultiplyPolynom(polyOne, polyTwo);
    }
}
