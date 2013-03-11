using System;

class Problem08
{
    static void Main()
    {
        Console.Write("enter number: ");
        short num = short.Parse(Console.ReadLine());
        string binary = "";
        string sign = "0";

        if (num < 0)
        {
            sign = "1";
            num *= -1;
            num -= 1;

            while (num != 0)
            {
                binary = (1 - num % 2).ToString() + binary;
                num /= 2;
            }

            binary = sign + new string('1', 15 - binary.Length) + binary;
            Console.WriteLine("it's 16-bit representation is: {0}", binary);
        }
        else
        {
            while (num != 0)
            {
                binary = (num % 2).ToString() + binary;
                num /= 2;
            }

            binary = sign + new string('0', 15 - binary.Length) + binary;
            Console.WriteLine("it's 16-bit representation is: {0}", binary);
        }
    }
}
