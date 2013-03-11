using System;

class Problem09
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
        //int[] nums = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, 1, 9, 1, 1, 2, 1, 8, 1, 3 };
        //int n = nums.Length;

        int mostFrequent = 0;
        int maxCount = 0;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequent = nums[i];
            }
        }

        //print result
        Console.WriteLine("{0}({1} times)", mostFrequent, maxCount);
    }
}
