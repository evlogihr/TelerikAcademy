using System;

class P01
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string strNum = Console.ReadLine();

        try
        {
            int num = int.Parse(strNum);
            Console.WriteLine("The square root of {0} is {1}", num, Math.Sqrt(num));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }
    }
}