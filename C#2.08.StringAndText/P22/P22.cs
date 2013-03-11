using System;
using System.Collections.Generic;
using System.IO;

class Word
{
    public string word { get; set; }
    public int count { get; set; }
}

class P22
{
    static void Main()
    {
        string input; //read long text from a file
        using (StreamReader text = new StreamReader("../../input.txt"))
        {
            input = text.ReadToEnd();
        }

        //remove punctuation
        char[] punctuation = { '.', ',', '!', '?', ')', '(', ':', ';', '"' };
        int index = input.IndexOfAny(punctuation, 0);
        while (index != -1)
        {
            input = input.Remove(index, 1);
            index = input.IndexOfAny(punctuation, index);
        }
        input = input.Replace("\r\n", " ");

        string[] split = input.Split(' ');
        List<Word> word = new List<Word>();
        for (int i = 0; i < split.Length; i++)
        {
            int j = 0;
            for (j = 0; j < word.Count; j++)
            {
                if (string.Compare(split[i], word[j].word, true) == 0)
                {
                    word[j].count++;
                    break;
                }
            }
            if (j == word.Count)
            {
                word.Add(new Word());
                word[j].word = split[i].ToLower();
                word[j].count = 1;
            }
        }

        word.Sort((x, y) => x.word.CompareTo(y.word));
        for (int i = 0; i < word.Count; i++)
        {
            Console.WriteLine("{0} - {1}", word[i].word, word[i].count);
        }
    }
}
