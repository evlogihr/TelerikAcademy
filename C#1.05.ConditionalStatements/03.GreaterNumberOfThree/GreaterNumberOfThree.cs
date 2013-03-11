using System;

class GreaterNumberOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers (on separate lines):");
        Console.Write("1st number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("2nd number: ");
        int numTwo = int.Parse(Console.ReadLine());
        Console.Write("3rd number: ");
        int numThree = int.Parse(Console.ReadLine());
        if (numOne > numTwo && numOne > numThree)
        {
            Console.WriteLine("The number {0} is greater the rest", numOne);
        }
        else if (numTwo > numThree)
        {
            Console.WriteLine("The number {0} is greater the rest", numTwo);
        }
        else
	    {
            Console.WriteLine("The number {0} is greater the rest", numThree);
	    }
    }
}