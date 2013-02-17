using System;

class P05
{
    static void Main()
    {
        string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        for (int indexOpen = -1, indexClose = -1;
            (indexOpen = input.IndexOf("<upcase>", indexOpen + 1)) != -1 && 
            (indexClose = input.IndexOf("</upcase>", indexClose + 1)) != -1; )
        {
            int len = indexClose - (indexOpen + 8);
            string change = input.Substring(indexOpen + 8, len);

            input = input.Remove(indexOpen, indexClose + 9 - indexOpen);
            input = input.Insert(indexOpen, change.ToUpper());
        }

        Console.WriteLine(input);
    }
}
