using System;
using System.IO;

class P10
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            string text = input.ReadToEnd();
            int indexClose = 0;
            int indexOpen = 0;
            string result = "";

            while (indexClose != -1)
            {
                indexOpen = text.IndexOf("</", indexOpen + 1); //find closing tag
                indexClose = text.LastIndexOf(">", indexOpen + 1); //find the last opening tag
                if (indexOpen != -1 && indexClose != -1 && indexOpen - indexClose != 1)
                {
                    result = text.Substring(indexClose + 1, (indexOpen - indexClose - 1));
                    result = result.Trim(); //(new char[] { ' ', '\t', '\n', '\r' });
                    Console.WriteLine(result);
                }
            }

        }
    }
}
