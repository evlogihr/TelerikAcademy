using System;
using System.Collections.Generic;
using System.IO;

class P06
{
    static void ReadFile(string adress, List<string> names)
    {
        using (StreamReader input = new StreamReader(adress))
        {
            string line = input.ReadLine();
            while (line != null)
            {
                names.Add(line);
                line = input.ReadLine();
            }
        }
    }

    static void Main()
    {
        string adress = "../../text.txt";
        List<string> names = new List<string>();

        ReadFile(adress, names);
        names.Sort();

        using (StreamWriter output = new StreamWriter("../../output.txt"))
        {
            foreach (string name in names)
            {
                output.WriteLine(name);
            }
        }
    }
}
