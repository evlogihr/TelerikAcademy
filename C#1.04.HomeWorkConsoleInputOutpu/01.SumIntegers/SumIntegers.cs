using System;

class SumIntegers
{
    static void Main()
    {
        while (true)
        {
            int numOne = 0;
            int numTwo = 0;
            int numThree = 0;
            Console.Write("1st number: ");
            string strNum = Console.ReadLine();
            if (int.TryParse(strNum, out numOne) == false)
            {
                Console.WriteLine("This number is invalid!");
            }
            else
            {
                Console.Write("2nd number: ");
                strNum = Console.ReadLine();
                if (int.TryParse(strNum, out numTwo) == false)
                {
                    Console.WriteLine("This number is invalid!");
                }
                else
                {
                    Console.Write("3rd number: ");
                    strNum = Console.ReadLine();
                    if (int.TryParse(strNum, out numThree) == false)
                    {
                        Console.WriteLine("This number is invalid!");
                    }
                    else
                    {
                        Console.WriteLine("The sum of the three is: {0}", numOne + numTwo + numThree);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
