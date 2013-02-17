using System;

class Problem02
{
    static void Main()
    {
        Console.Write("enter binary number: ");
        string bin = Console.ReadLine();
        //string bin = "1110001";

        int num = 0;
        int n = 1;
        foreach (char digit in bin)
        {
            num += (digit - '0') * (int)Math.Pow(2, bin.Length - n);
            n++;
        }

        Console.WriteLine("it's decimal representation: {0}", num);
    }
}
