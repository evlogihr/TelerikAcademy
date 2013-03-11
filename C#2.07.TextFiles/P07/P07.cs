using System;
using System.IO;

class P07
{
    static void Main()
    {
        string inputStr = "../../input.txt";
        string outputStr = "../../output.txt";

        StreamReader input = new StreamReader(inputStr);
        using (StreamWriter output = new StreamWriter(outputStr))
        {
            for (string line; (line = input.ReadLine()) != null;)
            {
                output.WriteLine(line.Replace("start", "finish"));
            }
        }
    }
}
