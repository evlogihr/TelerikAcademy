using System;

class Problem02
{
    static int GetMax(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
    static void Main()
    {
        Console.Write("num1 = ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("num2 = ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("num3 = ");
        int num3 = int.Parse(Console.ReadLine());
        int max = GetMax(GetMax(num1, num2), num3);
        Console.WriteLine("biggest number = {0}", max); 
    }
}
