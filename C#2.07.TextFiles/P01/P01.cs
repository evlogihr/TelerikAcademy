using System;
using System.IO;

class P01
{
    static void Main()
    {
        using (StreamReader text = new StreamReader("../../text.txt"))
        {
            int lineNum = 1;
            string lineText;
            while ((lineText = text.ReadLine()) != null)
            {
                if (lineNum % 2 == 1)
                {
                    Console.WriteLine("line{0}: {1}", lineNum, lineText);
                }
                lineNum++;
            }
        }
    }
}
