using System;

class P20
{
    static void Main()
    {
        string input = "Some random text with palindromes like level, radar and madam. ABBA is some form of lamal. The end is exe.";
        string[] word = input.Split(' ');
        char[] punctuation = { ' ', '.', ',', '!', '?' };

        for (int i = 0; i < word.Length; i++)
        {
            word[i] = word[i].Trim(punctuation);
            char[] letter = word[i].ToCharArray();
            for (int j = 0; j < letter.Length / 2; j++)
            {
                if (letter[j] != letter[letter.Length - 1 - j])
                {
                    break;
                }
                if (j == letter.Length / 2 - 1)
                {
                    Console.WriteLine(word[i]);
                }
            }
        }
    }
}
