using System;
using System.Collections.Generic;
using System.IO;

class P09
{
    static void Main()
    {
        List<string> evenLines = new List<string>();
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            int lineNum = 1;
            for (string line; (line = input.ReadLine()) != null; lineNum++ )
            {
                if (lineNum % 2 == 0)
                {
                    evenLines.Add(line);
                }
            }
        }

        using (StreamWriter output = new StreamWriter("../../input.txt"))
        {
            foreach (string line in evenLines)
            {
                output.WriteLine(line);
            }
        }
    }
}