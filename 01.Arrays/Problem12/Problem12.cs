using System;
using System.Globalization;

class Problem12
{
    static void Main()
    {
        string lower = "abcdefghijklmnopqrstuvwxyz";
        //string upper = lower.ToUpper(); //if need to check uppercase

        //read input
        Console.Write("wright a word: ");
        string input = Console.ReadLine();

        int[] index = new int[input.Length];

        for (int ch = 0; ch < input.Length; ch++)
        {
            for (int i = 0; i < lower.Length; i++)
            {
                if (input[ch] == lower[i])
                {
                    index[ch] = i + 1;
                    break;
                }
            }
        }

        //print result
        Console.WriteLine(string.Join(", ", index));
    }
}
