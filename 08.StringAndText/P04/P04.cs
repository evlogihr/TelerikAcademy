using System;

class P04
{
    static void Main()
    {
        string input = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        int count = 0;
        for (int index = -1; (index = input.IndexOf("in", index + 1,StringComparison.OrdinalIgnoreCase)) != -1; )
        {
            count++;
        }

        Console.WriteLine("result: {0}", count);
    }
}
