using System;

class Problem08
{
    static void Main()
    {
        //read input
        Console.Write("Enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array elements:");
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        //for easy checking comment all the above and use this
        //int[] nums = { 2, -3, 1, -3, 2, -3, 1, -2 };
        //int[] nums = { -5, -3, -6, -1, -2, -1, -6, -4, -8, -8, -3, -6, -1, -2, -1, -6, -4, -25, -8, -3, -6, -1, -2, -1, -6, -4, -3, -8 };
        //if all numbers are negative, will give the largest number
        //int[] nums = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8, 3, -6, -1, 2, -1, 6, 4, -25, 8, 3, -6, -1, 2, -1, 6, 4, -3, 8 };
        //int n = nums.Length;


        int bestSum = int.MinValue;
        int bestStartIndex = 0;
        int bestLength = 0;
        int sum = 0;
        int startIndex = 0;
        int length = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (sum < 0)
            {
                sum = 0;
                length = 0;
                startIndex = i;
            }
            sum += nums[i];
            length++;
            if (sum >= bestSum)
            {
                bestSum = sum;
                bestStartIndex = startIndex;
                bestLength = length;
            }
        }

        //print results
        Console.Write("Maximum sum sequence is: {");
        for (int i = 0; i < bestLength; i++)
        {
            if (i < bestLength - 1)
            {
                Console.Write("{0}, ", nums[bestStartIndex + i]);
            }
            else
            {
                Console.Write("{0}", nums[bestStartIndex + i]);
            }
        }
        Console.WriteLine("} = " + bestSum);
    }
}
