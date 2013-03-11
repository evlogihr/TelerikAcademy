using System;

class SortThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers (on separate lines):");
        Console.Write("1st number: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("2nd number: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("3rd number: ");
        int n3 = int.Parse(Console.ReadLine());
        if (n1 > n2)
        {
            if (n2 > n3)
            {
                if (n2 > n3)
                {
                    Console.WriteLine("in descending order {0}, {1}, {2}.", n1, n2, n3);
                }
                else
                {
                    Console.WriteLine("in descending order {0}, {1}, {2}.", n1, n3, n2);
                }
            }
            else
            {
                Console.WriteLine("in descending order {0}, {1}, {2}.", n3, n1, n2);
            }
        }
        else
        {
            if (n1 > n3)
            {
                Console.WriteLine("in descending order {0}, {1}, {2}.", n2, n1, n3);
            }
            else
            {
                if (n2 > n3)
                {
                    Console.WriteLine("in descending order {0}, {1}, {2}.", n2, n3, n1);
                }
                else
                {
                    Console.WriteLine("in descending order {0}, {1}, {2}.", n3, n2, n1);
                }
            }
        }
    }
}