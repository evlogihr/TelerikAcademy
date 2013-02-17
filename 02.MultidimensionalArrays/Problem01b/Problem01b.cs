using System;

class Problem01b
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] num = new int[n, n];

        int i = 1;
        int move = 1;
        int col = 0;
        int row = 0;
        while (col < n)
        {
            while (row < n && row >= 0)
            {
                num[row, col] = i;
                row += move;
                i++;
            }
            if (row > n - 1)
            {
                move = -1;
                row += move;
                col++;
            }
            else if (row < 0)
            {
                move = 1;
                row += move;
                col++;
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