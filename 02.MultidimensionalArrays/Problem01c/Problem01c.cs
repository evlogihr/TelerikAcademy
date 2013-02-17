using System;

class Problem01c
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] num = new int[n, n];

        int i = 1;
        int move = 1;
        int col = 0;
        int row = n - 1;
        while (col < n)
        {
            num[row, col] = i;
            i++;
            row++;
            col++;
            if (col > n - 1)
            {
                col = n - row + 1;
                row = 0;
            }
            else if (row > n - 1)
            {
                row = n - col - 1;
                col = 0;
            }
        }

        //print
        for (row = 0; row < n; row++)
        {
            for (col = 0; col < n; col++)
            {
                Console.Write("{0, 3}", num[row, col]);
            }
            Console.WriteLine();
        }
    }
}
