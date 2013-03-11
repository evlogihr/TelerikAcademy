using System;
using System.Collections.Generic;

class Problem03
{
    static void Main()
    {
        string[,] matrix = {
                              {"ha", "fi", "xx", "hi", "xx", "hi"},
                              {"ha", "hi", "xx", "tt", "ex", "hi"},
                              {"fa", "fi", "hx", "hi", "tt", "hr"},
                              {"gr", "fi", "xx", "tt", "xx", "rr"},
                              {"fa", "fy", "tt", "hi", "xx", "rr"},
                              {"ha", "fy", "xx", "fi", "rx", "hi"},
                              {"ha", "fi", "xx", "hi", "rx", "hi"},
                          };

        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int maxLength = 0;
        string maxElement = null;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                int length = 1;
                if (row + 1 < n && matrix[row, col] == matrix[row + 1, col])
                {
                    length = 2;
                    for (int i = 2; i < n - row; i++)
                    {
                        if (matrix[row, col] == matrix[row + i, col])
                        {
                            length++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (maxLength < length)
                {
                    maxLength = length;
                    maxElement = matrix[row, col];
                    length = 1;
                }
                if (col + 1 < m && matrix[row, col] == matrix[row, col + 1])
                {
                    length = 2;
                    for (int i = 2; i < m - col; i++)
                    {
                        if (matrix[row, col] == matrix[row, col + i])
                        {
                            length++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (maxLength < length)
                {
                    maxLength = length;
                    maxElement = matrix[row, col];
                    length = 1;
                }
                if (row + 1 < n && col + 1 < m && matrix[row, col] == matrix[row + 1, col + 1])
                {
                    length = 2;
                    for (int i = 2; i < Math.Min(n - row, m - col); i++)
                    {
                        if (matrix[row, col] == matrix[row + i, col + i])
                        {
                            length++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (maxLength < length)
                {
                    maxLength = length;
                    maxElement = matrix[row, col];
                    length = 1;
                }
                if (row + 1 < n && col - 1 >= 0 && matrix[row, col] == matrix[row + 1, col - 1])
                {
                    length = 2;
                    for (int i = 2; i < Math.Min(n - row, col); i++)
                    {
                        if (matrix[row, col] == matrix[row + i, col - i])
                        {
                            length++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (maxLength < length)
                {
                    maxLength = length;
                    maxElement = matrix[row, col];
                    length = 1;
                }

            }
        }

        //print result
        for (int i = 0; i < maxLength; i++)
        {
            if (maxLength - i > 1)
            {
                Console.Write(maxElement + ", ");
            }
            else
            {
                Console.Write(maxElement);
            }
        }
        Console.WriteLine();
    }
}
