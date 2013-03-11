using System;

class Problem04
{
    static int CountElement(double number, double[] numbers)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (number == numbers[i])
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        double[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 1, 2 };
        Console.Write("enter number = ");
        double input = double.Parse(Console.ReadLine());
        int result = CountElement(input, num);
        Console.WriteLine("the number {0} is repeated {1} time(s) in the arrray", input, result);

        //test
        bool works = CountElement(1, num) == 3;
        Console.WriteLine();
        if (works)
        {
            Console.WriteLine("the method works!");
        }
        else
        {
            Console.WriteLine("the method dosn't work!");
        }
    }
}
