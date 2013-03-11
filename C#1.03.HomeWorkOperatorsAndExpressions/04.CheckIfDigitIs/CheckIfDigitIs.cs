using System;

class Program
{
    static void Main()
    {
        Console.Write("Type in a big number: ");
        string strNum = Console.ReadLine();
        int num = 0;
        if (int.TryParse(strNum, out num) == true)
        {
            int cent = num / 100;
            if (cent % 10 == 7)
            {
                Console.WriteLine("The third digit of this number is 7");
            }
            else
            {
                Console.WriteLine("The third digit of this number is not 7");
            }
        }
        else
        {
            Console.WriteLine("{0} is not a valid number!", strNum);
        }
    }
}

