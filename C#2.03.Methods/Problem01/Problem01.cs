using System;

class Problem01
{
    static void PrintName(string name)
    {
        Console.WriteLine("Hello, " + name);
    }
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        PrintName(name);
    }
}
