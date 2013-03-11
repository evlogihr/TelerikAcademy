using System;
using System.Collections.Generic;

class Symbol
{
    public char symbol { get; set; }
    public int count { get; set; }
}

class P21
{
    static void Main()
    {
        string input = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found";
        input = input.Replace(" ", "");
        List<Symbol> letter = new List<Symbol>();

        foreach (char ch in input)
        {
            int i = 0;
            for (i = 0; i < letter.Count; i++)
            {
                if (ch == letter[i].symbol)
                {
                    letter[i].count++;
                    break;
                }
            }
            if (i == letter.Count)
            {
                letter.Add(new Symbol());
                letter[i].symbol = ch;
                letter[i].count = 1;
            }
        }

        letter.Sort((x, y) => y.count.CompareTo(x.count));
        for (int i = 0; i < letter.Count; i++)
        {
            Console.WriteLine("{0} - {1}", letter[i].symbol, letter[i].count);
        }
    }
}
