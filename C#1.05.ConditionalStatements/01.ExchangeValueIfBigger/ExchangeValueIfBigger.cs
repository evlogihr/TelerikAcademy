using System;

class ExchangeValueIfBigger
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
                int biggerNum = numOne;
                if (numOne < numTwo)
                {
                    biggerNum = numTwo;
                }
                Console.WriteLine("The greater of both is {0}", biggerNum);
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