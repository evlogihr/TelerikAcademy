using System;
using System.Threading;
using System.Globalization;

class P19
{
    static void Main()
    {
        string input = "I was born on the 14.06.1980. My sister was born on the 3.7.1984. In 5/1999 i graduated my high school. The law says (see section 7.3.12) that we are alowed to do this (section 7.4.2.9).";
        string[] word = input.Split(' ');
        char[] punctuation = { ' ', '.', ',', '!', '?' };

        for (int i = 0; i < word.Length; i++)
        {
            DateTime date;
            word[i] = word[i].Trim(punctuation);
            if (DateTime.TryParseExact(word[i], "d.M.yyyy", null, DateTimeStyles.None, out date))
            {
                Console.WriteLine("{0}", date.ToString(new CultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}
