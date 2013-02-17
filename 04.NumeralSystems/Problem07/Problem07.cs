using System;

class Problem07
{
    static void Main()
    {
        Console.Write("enter number = ");
        string input = Console.ReadLine();
        Console.Write("enter s = ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("enter d = ");
        int d = int.Parse(Console.ReadLine());

        string arr = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        int n = 1;
        string result = "";
        int temp = 0; //use int to store the number

        foreach (char ch in input)
        {
            temp += (ch - '0') * (int)(Math.Pow(s, input.Length - n)); //convert form s to decimal
            n++;
        }

        while (temp > 0)
        {
            result = arr.Substring((temp % d), 1) + result; //convert from decimal to d
            temp /= d;
        }

        //print resultat
        Console.WriteLine("it's {0} representation is: {1}", d, result);
    }
}
