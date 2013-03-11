using System;
using System.IO;

class P05
{
    static int[,] ReadMatrix(string adress)
    {
        int[,] matrix;
        using (StreamReader textFile = new StreamReader(adress))
        {
            int n = int.Parse(textFile.ReadLine());
            matrix = new int[n, n];

            int lineNum = 0;
            string line;
            while ((line = textFile.ReadLine()) != null)
            {
                string[] temp = line.Split(' ');
                for (int col = 0; col < n; col++)
                {
                    matrix[lineNum, col] = int.Parse(temp[col]);
                }
                lineNum++;
            }
        }
        return matrix;
    }

    static int MaxSum2x2(int[,] matrix)
    {
        int maxSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        return maxSum;
    }

    static void Main()
    {
        string adress = "../../matrix.txt";
        int[,] matrix;

        matrix = ReadMatrix(adress);

        int result = MaxSum2x2(matrix);

        using (StreamWriter output = new StreamWriter("../../result.txt"))
        {
            output.WriteLine(result);
        }
    }
}
