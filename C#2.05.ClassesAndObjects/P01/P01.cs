using System;

class P01
{
    static void Main()
    {
        Console.Write("enter year = ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} is a leap year", year);
        }
        else
        {
            Console.WriteLine("{0} is NOT a leap year", year);
        }
    }
}
