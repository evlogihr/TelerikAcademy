﻿using System;

class Problem05
{
    static void Main()
    {
        Console.Write("enter hexadecimal number: ");
        string hex = Console.ReadLine();
        //string hex = "12FF";

        string bin = null;
        foreach (char digit in hex)
        {
            switch (digit)
            {
                case '0': bin += "0000"; break;
                case '1': bin += "0001"; break;
                case '2': bin += "0010"; break; 
                case '3': bin += "0011"; break;
                case '4': bin += "0100"; break;
                case '5': bin += "0101"; break;
                case '6': bin += "0110"; break;
                case '7': bin += "0111"; break;
                case '8': bin += "1000"; break;
                case '9': bin += "1001"; break;
                case 'a':             
                case 'A': bin += "1010"; break;
                case 'b':             
                case 'B': bin += "1011"; break;
                case 'c':             
                case 'C': bin += "1100"; break;
                case 'd':             
                case 'D': bin += "1101"; break;
                case 'e':             
                case 'E': bin += "1110"; break;
                case 'f':             
                case 'F': bin += "1111"; break;
                default: break;
            }
        }

        Console.WriteLine("it's binary representation: {0}", bin);
    }
}
