using System;
using System.Collections.Generic;
using System.Text;

class P13
{
    static void Main()
    {
        string[] input = "C# is not C++, not PHP and not Delphi!".Split(' '); //Console.ReadLine();
        StringBuilder output = new StringBuilder();
        string[] punctsign = new string[input.Length];

        char[] allpunct = { ',', '.', '!', '?', ';', '-' };

        for (int i = 0; i < input.Length; i++)
        {
            int start = 0;
            start = input[i].IndexOfAny(allpunct, start);
            if (start != -1)
            {
                punctsign[i] = input[i].Substring(start, 1);
                input[i] = input[i].Trim(allpunct);
            }
        }

        for (int i = 0; i < input.Length; i++)
        {
            output.Append(input[input.Length - 1 - i]);
            output.Append(punctsign[i]);
            output.Append(" ");
        }
        Console.WriteLine(output);
    }
}
