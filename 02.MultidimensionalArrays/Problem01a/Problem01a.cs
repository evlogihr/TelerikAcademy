using System;

class Problem01a
{
    static void Main()
    {
        //read input
        int n = int.Parse(Console.ReadLine());
        int[,] num = new int[n, n];

        int i = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++, i++)
            {
                num[row, col] = i;
            }
        }

        //print
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 3}", num[row, col]);
            }
            Console.WriteLine();
        }
    }
}