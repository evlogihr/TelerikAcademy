using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter output = new StreamWriter("../../output.txt.");
            using (output)
            {
                for (int i = 0; i < 10000; i++)
                {
                    output.Write(i % 10 + ", ");
                }
            }
        }
    }
}
