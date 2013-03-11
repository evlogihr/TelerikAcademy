using System;

class MyAge
{
    static void Main()
    {
        Console.Write("How old are you: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("In 10 years you'll be: ");
        int sum = age + 10;
        Console.WriteLine(sum);
    }
}
