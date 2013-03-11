using System;
using System.Text;

class Program
{
    static void Main()
    {
        byte hight = 3;
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 1; i <= hight; i++)
        {
            for (int j = 0; j < hight - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i * 2 - 1; j++)
            {
                Console.Write("\u00a9");
            }
            Console.WriteLine();
        }
    }
}
