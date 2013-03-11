using System;


class Program
{
    static void Main()
    {
        int firstNum = 0;
        int secondNum = 0;
        int sum = 0;
        Console.Write("Type 1st number: ");
        string strFirstNum = Console.ReadLine();
        if (int.TryParse(strFirstNum, out firstNum) == true)
        {
            Console.Write("Type 2nd number: ");
            string strSecondNum = Console.ReadLine();
            if (int.TryParse(strSecondNum, out secondNum) == true)
            {
                sum = Math.Max(firstNum, secondNum) / 5 - Math.Min(firstNum, secondNum) / 5;
                Console.WriteLine("p({0},{1}) = {2}", firstNum, secondNum, sum);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}