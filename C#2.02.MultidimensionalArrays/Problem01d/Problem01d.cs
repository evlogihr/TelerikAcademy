using System;

class Problem01d
{
    static void Main()
    {
        //read input
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        //calculate matrix
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        string move = "down";
        for (int i = 1; i <= n * n; i++)
        {
            matrix[row, col] = i;
            switch (move)
            {
                case "down": row++; break;
                case "right": col++; break;
                case "up": row--; break;
                case "left": col--; break;
                default: break;
            }

            //check if need to change direction
            if ((row == n - 1 || matrix[row + 1, col] != 0) && move == "down")
            {
                move = "right";
            }
            else if ((col == n - 1 || matrix[row, col + 1] != 0) && move == "right")
            {
                move = "up";
            }
            else if ((row == 0 || matrix[row - 1, col] != 0) && move == "up")
            {
                move = "left";
            }
            else if ((col == 0 || matrix[row, col - 1] != 0) && move == "left")
            {
                move = "down";
            }
        }

        //print result
        for (row = 0; row < matrix.GetLength(0); row++)
        {
            for (col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}