using System;

class Problem03
{
    static void Main()
    {
        Console.Write("enter a number: ");
        int num = int.Parse(Console.ReadLine());

        string hex = "";
        while (num > 0)
        {
            int hexNum = num % 16;
            if (hexNum > 9)
            {
                switch (hexNum)
                {
                    case 10: hex = "A" + hex; break;
                    case 11: hex = "B" + hex; break;
                    case 12: hex = "C" + hex; break;
                    case 13: hex = "D" + hex; break;
                    case 14: hex = "E" + hex; break;
                    case 15: hex = "F" + hex; break;
                    default: break;
                }
            }
            else
            {
                hex = hexNum + hex;
            }
            num /= 16;
        }

        Console.WriteLine("it's hexadecimal representation is: {0}", hex);
    }
}
