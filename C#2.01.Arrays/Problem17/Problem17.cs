using System;

class Problem17
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
        //same logic as previous problem, just added a check for k

        //for easy checking comment all the above and use this
        //int k = 3;
        //int s = 20;
        //int[] num = { 31, 21, 3, 24, 15, 6, 17, 8, 9, 12, 18, 12, 43, -16, -4, -10, 10 };
        //int n = num.Length;

        int maxComb = (int)Math.Pow(2, n) - 1;
        int comb = 0;
        bool exist = false;
        for (comb = 1; comb < maxComb; comb++)
        {
            int sum = 0;
            int count = 0;
            for (int bit = 0; bit < n; bit++)
            {
                if (((comb >> bit) & 1) == 1)
                {
                    sum += ((comb >> bit) & 1) * num[bit];
                    count++;
                }
            }
            if (sum == s && count == k) //check
            {
                exist = true;
                break;
            }
        }

        //print
        if (exist)
        {
            int sum = 0;
            Console.Write("(");
            for (int bit = 0; bit < n; bit++)
            {
                int element = ((comb >> bit) & 1) * num[bit];
                sum += element;
                if (element != 0)
                {
                    if (sum != s)
                    {
                        Console.Write(element + " + ");
                    }
                    else
                    {
                        Console.Write(element);
                    }
                }
            }
            Console.WriteLine(") = {0}", s);
        }
        else
        {
            Console.WriteLine("not found");
        }
    }
}
