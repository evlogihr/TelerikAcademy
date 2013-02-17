using System;
using System.Globalization;

class P16
{
    static void Main()
    {
        string format = "d.MM.yyyy";
        Console.Write("Enter the first date: ");
        DateTime first = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
        Console.Write("Enter the second date: ");
        DateTime second = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);

        TimeSpan diff = second - first;
        Console.WriteLine("Distance: {0} days", diff.Days);
    }
}
