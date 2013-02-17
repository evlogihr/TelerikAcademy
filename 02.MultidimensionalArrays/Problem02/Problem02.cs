using System;

class Problem02
{
    static void Main()
    {
        //Console.Write("enter number of rows: ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("enter number of collums: ");
        //int m = int.Parse(Console.ReadLine());
        //int[,] matrix = new int[n, m];
        //for (int row = 0; row < n; row++)
        //{
        //    for (int col = 0; col < m; col++)
        //    {
        //        Console.Write("matrix({0}|{1}) = ", row, col);
        //        matrix[row, col] = int.Parse(Console.ReadLine());
        //    }
        //}

        int[,] matrix = {
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 },
            {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 },
            {3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 },
            {4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 },
            {5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 },
            {6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
            {7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 },
            {8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 },
            {9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 },
            {10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 }
        };
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        int maxSum = int.MinValue;
        int[] elem = new int[2];
        for (int row = 1; row < n - 1; row++)
        {
            for (int col = 1; col < m - 1; col++)
            {
                int sum = matrix[row-1, col-1] + matrix[row-1, col] + matrix[row-1, col+1]
                        + matrix[row, col-1] + matrix[row, col] + matrix[row, col+1]
                        + matrix[row+1, col-1] + matrix[row+1, col] + matrix[row+1, col+1];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    elem[0] = row;
                    elem[1] = col;
                }
            }
        }

        Console.WriteLine("Maximum sum:");
        for (int row = elem[0] - 1; row <= elem[0] + 1; row++)
        {
            Console.Write("|");
            for (int col = elem[1] - 1; col <= elem[1] + 1; col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }
            Console.WriteLine("|");
        }
        Console.WriteLine(" = {0}", maxSum);
    }
}
