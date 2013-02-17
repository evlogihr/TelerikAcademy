using System;
using System.IO;

class P03
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader("../../input.txt");
        StreamWriter outputText = new StreamWriter("../../output.txt");

        using (outputText)
        {
            int lineNum = 1;
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                outputText.WriteLine("{0}.{1}", lineNum, line);
                lineNum++;
            }
        }
    }
}
