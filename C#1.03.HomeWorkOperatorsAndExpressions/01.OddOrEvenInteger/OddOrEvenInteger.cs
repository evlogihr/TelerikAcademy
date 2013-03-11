using System;

class OddOrEvenInteger
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter an number: ");
            string strNum = Console.ReadLine();
            int num = 0;
            if (int.TryParse(strNum, out num) == true)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("{0} is even\n", num);
                }
                else
                {
                    Console.WriteLine("{0} is odd\n", num);
                }
            }
            else
            {
                Console.WriteLine("Invalid number!\n");
            }
        }
    }
}