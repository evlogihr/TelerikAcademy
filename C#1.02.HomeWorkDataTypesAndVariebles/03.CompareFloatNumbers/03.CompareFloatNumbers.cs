using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter the first number to compare: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.Write("Enter the second number to compare: ");
        float num2 = float.Parse(Console.ReadLine());
        bool compare = (num1 == num2);
        Console.WriteLine(compare);
    }
}