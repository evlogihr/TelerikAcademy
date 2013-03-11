using System;

class P09
{
    static void Main()
    {
        string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] words = { "PHP", "CLR", "Microsoft" };

        for (int i = 0; i < words.Length; i++)
        {
            string asterisk = new string('*', words[i].Length);
            input = input.Replace(words[i], asterisk);
        }

        Console.WriteLine(input);
    }
}
