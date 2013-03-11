using System;

class SumNNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to summ: ");
        string strNum = Console.ReadLine();
        int num = 0;
        int n = 0;
        int sum = 0;
        if (int.TryParse(strNum, out num) == true)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter number {0}: ", i+1);
                string strN = Console.ReadLine();
                if (int.TryParse(strN, out n) == true)
                {
                    sum = sum + n;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            Console.WriteLine("\nTotal summ: {0}\n", sum);
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}