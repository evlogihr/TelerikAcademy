using System;
using System.Collections.Generic;

class P14
{
    static void Main()
    {
        string input = ".NET"; //Console.ReadLine();

        Dictionary<string, string> dictionary = new Dictionary<string, string>(){
            { ".NET", "platform for applications from Microsoft" },
            { "CLR", "managed execution environment for .NET" },
            { "namespace", "hierarchical organization of classes" }
        };

        Console.WriteLine("{0} - {1}", input, dictionary[input]);
    }
}
