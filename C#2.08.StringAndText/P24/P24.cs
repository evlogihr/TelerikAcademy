using System;
using System.Collections.Generic;

class P24
{
    static void Main()
    {
        string input = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order";

        //remove punctuation
        char[] punctuation = { '.', ',', '!', '?', ')', '(', ':', ';', '"' };
        int index = input.IndexOfAny(punctuation, 0);
        while (index != -1)
        {
            input = input.Remove(index, 1);
            index = input.IndexOfAny(punctuation, index);
        }
        input = input.Replace("\r\n", " "); //remove new lines

        string[] split = input.Split(' ');

        Array.Sort(split);
        for (int i = 0; i < split.Length; i++)
        {
            Console.WriteLine(split[i]);
        }
    }
}
