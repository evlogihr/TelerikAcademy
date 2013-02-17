using System;
using System.Text;

class P06
{
    static void Main()
    {
        StringBuilder output = new StringBuilder();
        output.Append(Console.ReadLine());
        try
        {
            output.Append('*', (20 - output.Length));
            Console.WriteLine(output);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("input text > 20 chars");
        }
    }
}
