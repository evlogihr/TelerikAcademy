using System;

class PrintAllNNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string strNum = Console.ReadLine();
        int num = 0;
        if (int.TryParse(strNum, out num) == true)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}
