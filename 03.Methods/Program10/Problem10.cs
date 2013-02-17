using System;
using System.Collections.Generic;

class Problem10
{
    static List<byte> MultiplyArrays(List<byte> input, byte[] mtpl)
    {
        List<byte> factorial = new List<byte>(input.Count + mtpl.Length - 1); //make new list to store the result
        for (int i = 0; i < input.Count + mtpl.Length - 1; i++) //set all 0 in the new list
        {
            factorial.Add(0);
        }
        for (byte i = 0; i < mtpl.Length; i++)
        {
            if (mtpl[i] != 0) //be sure to not multiply by 0
            {
                for (byte j = 0; j < input.Count; j++)
                {
                    factorial[i + j] += (byte)(input[j] * mtpl[i]);
                }
            }
        }
        TransferDigit(factorial);
        return factorial;
    }

    static void TransferDigit(List<byte> factorial)
    {
        for (byte i = 0; i < factorial.Count; i++)
        {
            if (factorial[i] > 9)
            {
                if (i == factorial.Count - 1) //if last digit > 9 extend the List
                {
                    factorial.Add((byte)(factorial[i] / 10));
                    factorial[i] = (byte)(factorial[i] % 10);
                }
                else
                {
                    factorial[i + 1] += (byte)(factorial[i] / 10);
                    factorial[i] %= 10;
                }
            }
        }
    }

    static void IntToArray(byte num, out byte[] arr)
    {
        int n = 0;
        if (num < 10) n = 1;
        else if (num < 100) n = 2;
        else n = 3;

        arr = new byte[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = (byte)(num % 10);
            num /= 10;
        }
    }

    static void Main()
    {
        Console.Write("enter number = ");
        byte num = byte.Parse(Console.ReadLine()); //max 145

        byte[] mtpl = new byte[2];
        List<byte> factorial = new List<byte>(1);
        factorial.Add(1);

        for (byte i = 1; i <= num; i++)
        {
            IntToArray(i, out mtpl);
            factorial = MultiplyArrays(factorial, mtpl);
        }

        //print result
        Console.Write("{0}! = ", num);
        for (int i = factorial.Count - 1; i >= 0; i--)
        {
            Console.Write(factorial[i]);
        }
        Console.WriteLine();
    }
}