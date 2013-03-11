using System;

class IfDevidedBy5and7
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a number: ");
            string strNum = Console.ReadLine();
            int num = 0;
            if (int.TryParse(strNum, out num) == true)
            {
                if (num % 5 == 0 && num % 7 == 0)
                {
                    Console.WriteLine("The number {0} can be devided by 5 and 7\n", num);
                }
                else
                {
                    Console.WriteLine("The number {0} can not be devided by 5 and 7\n", num);
                }
            }
            else
            {
                Console.WriteLine("Invalid number!\n");
            }
        }
    }
}