using System;

class Problem16
{
    static long MaxCombinations(int n, long maxComb = 1)
    {
        for (int i = 0; i < n; i++) //faster than Math.Pow
        {
            maxComb *= 2;
        }
        return maxComb - 1;
    }

    static void Main()
    {
        //read input
        Console.Write("s = ");
        long s = long.Parse(Console.ReadLine());

        //long[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        long[] num = { 5, 13, -6, -11, 2, 51, 21, 6, 4, -8, 8, 23, 6, 4, -8, 16, 9, 24, -3, 59, 33, -28, 40, 42 };
        int n = num.Length;

        long maxComb = MaxCombinations(n); //calculate all possible combinations, can work for max 63 long array
        
        long sum = 0;
        long comb = 0;
        bool exist = false;
        for (comb = 1; comb < maxComb; comb++)
        {
            sum = 0;
            for (int j = 0; j < n; j++)
            {
                if (((comb >> j) & 1) == 1)
                {
                    sum += ((comb >> j) & 1) * num[j]; //gets the element form the array, if the bit in the same position is 1
                }
            }
            if (sum == s) //check if the sum of the combination is = s
            {
                exist = true;
                break;
            }
        }

        if (exist)
        {
            sum = 0;
            Console.Write("yes (");
            for (int bit = 0; bit < n; bit++)
            {
                if (((comb >> bit) & 1) == 1)
                {
                    sum += num[bit];
                    Console.Write(num[bit]);
                }
                if (((comb >> bit) & 1) == 1 && sum < s)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine(")");
        }
        else
        {
            Console.WriteLine("combination not found");
        }
    }
}
