using System;

class Problem13
{
    static void LinearEquasion()
    {
        Console.Write("enter a = ");
        double a = double.Parse(Console.ReadLine());
        if (a != 0)
        {
            Console.Write("enter b = ");
            double b = double.Parse(Console.ReadLine());
            double x = b / a;
            Console.WriteLine("x = {0}", x);
        }
        else
        {
            Console.WriteLine("a should not be 0");
        }
    }

    static void AveregeOfSequence()
    {
        Console.Write("enter length of the sequence: ");
        int n = int.Parse(Console.ReadLine());
        if (n != 0)
        {
            Console.WriteLine("enter sequence of integers:");
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            double average = sum / n;
            Console.WriteLine("the average is: {0}", average);
        }
        else
        {
            Console.WriteLine("sequence cannot be empty!");
        }
    }

    static void ReverceNumber()
    {
        Console.Write("enter a number: ");
        int num = int.Parse(Console.ReadLine());
        if (num >= 0)
        {
            int revNum = 0;
            while (num > 0)
            {
                revNum = revNum * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine("the number with reverced digits: {0}", revNum);
        }
        else
        {
            Console.WriteLine("number cannot be negative!");
        }
    }

    static void Main()
    {
        bool cont = true;
        while (cont)
        {
            Console.WriteLine("1. reverce the digits of a number");
            Console.WriteLine("2. calculate the avarage of a sequence of integers");
            Console.WriteLine("3. solve a linear equasion");
            Console.Write("enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ReverceNumber();
                    break;
                case 2:
                    AveregeOfSequence();
                    break;
                case 3:
                    LinearEquasion();
                    break;
                default: break;
            }
            Console.Write("continue? (any/n) ");
            if (Console.ReadLine() == "n")
            {
                cont = false;
            }
            Console.WriteLine();
        }
    }
}
