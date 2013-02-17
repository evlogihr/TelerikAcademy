using System;
using System.IO;

class P25
{
    static void Main()
    {
        string input; //read text from a file
        using (StreamReader text = new StreamReader("../../input.html"))
        {
            input = text.ReadToEnd();
        }
        input = input.Replace("\r\n", "");
        input = input.Replace("   ", "");

        int start = input.IndexOf("<title>", 0) + 7;
        int end = input.IndexOf("</title>", start);
        string title = input.Substring(start, end - start);

        start = input.IndexOf("<body>", 0) + 6;
        end = input.IndexOf("</body>", start);
        string body = input.Substring(start, end - start);

        int indexOpen = body.IndexOf("<", 0);
        while (indexOpen != -1)
        {
            int indexClose = body.IndexOf(">", indexOpen);
            if (indexOpen > 0)
            {
                body = body.Replace(body.Substring(indexOpen, indexClose + 1 - indexOpen), " ");
            }
            else
            {
                body = body.Remove(indexOpen, indexClose + 1 - indexOpen);
            }
            indexOpen = body.IndexOf("<", indexOpen);
        }

        Console.WriteLine("title: {0}", title);
        Console.WriteLine("body: {0}", body);
    }
}
