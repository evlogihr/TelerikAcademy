using System;
using System.IO;

class P02
{
    static void Main()
    {
        StreamReader text1 = new StreamReader("../../text1.txt");
        StreamReader text2 = new StreamReader("../../text2.txt");

        using (StreamWriter allText = new StreamWriter("../../allText.txt"))
        {
            int lineNum = 0;
            string line;
            while ((line = text1.ReadLine()) != null)
            {
                allText.WriteLine(line);
                lineNum++;
            }
            lineNum = 0;
            line = text2.ReadLine();
            while (line != null)
            {
                allText.WriteLine(line);
                line = text2.ReadLine();
                lineNum++;
            }
        }
    }
}
