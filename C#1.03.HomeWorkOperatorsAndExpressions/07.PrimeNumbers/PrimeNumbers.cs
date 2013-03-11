using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number from 1 to 100: ");
        string strNum = Console.ReadLine();
        byte num = 0;
        if (byte.TryParse(strNum, out num) == true && num > 0 && num <= 100)
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("{0} is not prime \n", num);
                    return;
                }
            }
            Console.WriteLine("{0} is Prime \n", num);
	    }
        else
        {
            Console.WriteLine("Not a valid number!");
        }
    }
}