using System;
using System.IO;

class P04
{
    static void Main()
    {
        StreamReader text1 = new StreamReader("../../text1.txt");
        StreamReader text2 = new StreamReader("../../text2.txt");
        using (text1)
        {
            string lineText1;
            string lineText2;
            int equal = 0;
            int lineNum = 0;

            while ((lineText1 = text1.ReadLine()) != null
                && (lineText2 = text2.ReadLine()) != null)
            {
                if (lineText1 == lineText2)
                {
                    equal++;
                }
                lineNum++;
            }

            Console.WriteLine("Equal lines: {0}", equal);
            Console.WriteLine("Different lines: {0}", lineNum - equal);
        }
    }
}