using System;

class P23
{
    static void Main()
    {
        string input = "aaaaabbbbbcdddeeeedssaa";

        for (int i = 0; i < input.Length - 1; i++)
        {
            int length = 0;
            while (i < input.Length - 1 && input[i] == input[i + 1])
            {
                length++;
                i++;
            }
            input = input.Remove(i - length, length);
            i = i - length;
        }

        Console.WriteLine("output: {0}", input);
    }
}
