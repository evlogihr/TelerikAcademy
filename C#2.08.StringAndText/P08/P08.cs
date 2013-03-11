using System;
using System.Text;
using System.Text.RegularExpressions;

class P08
{
    static void Main()
    {
        string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        string[] sentance = input.Split('.');

        for (int i = 0; i < sentance.Length; i++)
        {
            if (sentance[i].IndexOf(" " + word + " ", StringComparison.OrdinalIgnoreCase) != -1)
            {
                Console.WriteLine(sentance[i].Trim() + ".");
            }
        }
    }
}
