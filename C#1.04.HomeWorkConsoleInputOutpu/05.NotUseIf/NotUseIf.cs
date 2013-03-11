using System;

class NotUseIf
{
    static void Main()
    {
        Console.Write("Enter 1st number: ");
        string strNumOne = Console.ReadLine();
        int numOne = 0;
        if (int.TryParse(strNumOne, out numOne) == true)
        {
            Console.Write("Enter 2nd number: ");
            string strNumTwo = Console.ReadLine();
            int numTwo = 0;
            if (int.TryParse(strNumTwo, out numTwo) == true)
            {
                int number = Math.Max(numOne, numTwo);
                Console.WriteLine("{0} is the greater of both.", number);
            }
            else
	        {
                Console.WriteLine("Not a valid number");
	        }
        }
        else
	    {
            Console.WriteLine("Not a valid number");
	    }
    }
}
