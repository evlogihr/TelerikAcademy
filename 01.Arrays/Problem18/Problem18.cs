using System;

class Problem18
{
    static void Main()
    {
        Console.Write("enter length of array n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("enter number of elements k = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("enter sum s = ");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("enter array: ");
        int[] num = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("num{0} = ", i);
            num[i] = int.Parse(Console.ReadLine());
        }

        //for easy checking comment all the above and use this
        //int[] num = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        //int[] num = { 31, 21, 3, 24, 15, 6, 17, 8, 9, 12, 18, 12, 43, -16, -4, -10, 10 };
        //int n = num.Length;

        int maxComb = (int)Math.Pow(2, n) - 1;
        int comb = 0;
        int bestLength = 0;
        int bestComb = 0;
        for (comb = maxComb; comb > 0; comb--)
        {
            int length = 0;
            int current = 0;
            int previous = int.MinValue;
            for (int bit = 0; bit < n; bit++)
            {
                if (((comb >> bit) & 1) == 1)
                {
                    current = ((comb >> bit) & 1) * num[bit];
                    if (previous <= current)
                    {
                        length++;
                        previous = current;
                    }
                    else //stop with this combination if not increasing order
                    {
                        length = 0;
                        break;
                    }
                }
            }

            //check length
            if (bestLength < length)
            {
                bestLength = length;
                bestComb = comb;
            }
        }

        //print
        Console.Write("longest increasing order: (");
        for (int bit = 0; bit < n; bit++)
        {
            int element = ((bestComb >> bit) & 1) * num[bit];
            if (element != 0)
            {
                if (bestLength != 1)
                {
                    Console.Write(element + ", ");
                    bestLength--; 
                }
                else
                {
                    Console.Write(element + ")");
                }
            }
        }
        Console.WriteLine();
    }
}