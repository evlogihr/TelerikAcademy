using System;
using System.Text;

class P02
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder output = new StringBuilder();

        foreach (char ch in input)
        {
            output.Insert(0, ch);
        }

        Console.WriteLine(output);
    }
}
