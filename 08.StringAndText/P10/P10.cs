using System;

class P10
{
    static void Main()
    {
        string input = "Hi!";
        foreach (char ch in input)
        {
            Console.Write("\\u{0:X4}", (int)ch);
        }
        Console.WriteLine();
    }
}
