using System;

class P07
{
    static void Main()
    {
        string input = "some text to be encoded";
        string cipherStr = "thecipher";
        char[] cipher = cipherStr.ToCharArray();

        int index = 0;
        string output = "";
        foreach (char ch in input)
        {
            output += ch ^ cipher[index];
            index++;
            if (index > cipher.Length - 1)
            {
                index = 0;
            }
        }
        Console.WriteLine(output);
    }
}