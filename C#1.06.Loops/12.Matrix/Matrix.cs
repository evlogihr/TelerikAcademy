using System;

class Matrix
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
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(i + j + 1);
            }
            Console.WriteLine();
        }
    }
}
