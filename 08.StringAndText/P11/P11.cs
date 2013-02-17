using System;

class P11
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("decimal number: {0,15}", num);
        Console.WriteLine("hexadecimal number: {0,15:X}", num);
        Console.WriteLine("percentage number: {0,15:P}", num);
        Console.WriteLine("scientific notation: {0,15:E}", num);
    }
}