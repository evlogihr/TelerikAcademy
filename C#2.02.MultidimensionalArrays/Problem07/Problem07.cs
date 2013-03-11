using System;

class Problem07
{
    static int CheckNext(int[,] matrix, byte[,] check, int row, int col, int count, int value)
    {
        if (col > -1 && col < matrix.GetLength(1) && row > -1 && row < matrix.GetLength(0))
        {
            if (matrix[row, col] == value && check[row, col] == 0)
            {
                count++;
                check[row, col] = 1;

                count = CheckNext(matrix, check, row, col - 1, count, value); //recursively call method to check left
                count = CheckNext(matrix, check, row, col + 1, count, value); //recursively call method to check right
                count = CheckNext(matrix, check, row + 1, col, count, value); //recursively call method to check top
                count = CheckNext(matrix, check, row - 1, col, count, value); //recursively call method to check bot
            }
        }
        return count;
    }

    static void Main()
    {
        int[,] matrix = 
        {
            {1, 3, 2, 2, 2, 4},
            {3, 3, 3, 2, 4, 4},
            {4, 3, 1, 2, 3, 3},
            {4, 3, 1, 3, 3, 1},
            {4, 3, 3, 3, 1, 1},
        };

        byte[,] check = new byte[matrix.GetLength(0), matrix.GetLength(1)]; //used to mark if elements are counted

        int maxCount = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int count = 0;
                int value = matrix[row, col];

                count = CheckNext(matrix, check, row, col - 1, count, value); //check left
                count = CheckNext(matrix, check, row, col + 1, count, value); //check right
                count = CheckNext(matrix, check, row + 1, col, count, value); //check top
                count = CheckNext(matrix, check, row - 1, col, count, value); //check bot

                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
        }

        Console.WriteLine("max area = {0}", maxCount);
    }
}