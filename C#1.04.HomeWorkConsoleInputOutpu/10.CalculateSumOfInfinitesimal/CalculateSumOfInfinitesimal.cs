using System;

class CalculateSumOfInfinitesimal
{
    static void Main()
    {
        float sum = 1f;
        for (float i = 2f; i <= 2000; i++)
        {
            if (i % 2 == 0)
            {
                sum = sum + 1 / i;
            }
            else
            {
                sum = sum - 1 / i;
            }
        }
        Console.WriteLine("Total sum = {0:0.000}", sum);
    }
}