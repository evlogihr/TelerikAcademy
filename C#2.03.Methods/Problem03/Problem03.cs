using System;

class Problem03
{
    static string LastDigit(int number)
    {
        number = number % 10;
        switch (number)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: break;
        }
        return null;
    }

    static void Main()
    {
        //while (true)
        //{
            Console.Write("enter number = ");
            int num = int.Parse(Console.ReadLine());
            string lastDigit = LastDigit(num);
            Console.WriteLine("the last digit is " + lastDigit);
        //}
    }
}
