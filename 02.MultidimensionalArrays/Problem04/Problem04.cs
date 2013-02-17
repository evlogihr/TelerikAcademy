using System;
using System.Collections;

class Problem04
{
    static void Main()
    {
        //Console.Write("n = ");
        //int n = int.Parse(Console.ReadLine());
        //int[] nums = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("num[{0}] = ", i);
        //    nums[i] = int.Parse(Console.ReadLine());
        //}
        //Console.Write("k = ");
        //int k = int.Parse(Console.ReadLine());

        //for testing
        int[] nums = { 15, 2, 13, 4, 10, 6, 1, 15, 24, 8, 9, 5 };
        int n = nums.Length;
        int k = 11;

        Array.Sort(nums);

        int index = Array.BinarySearch(nums, k);
        if (index >= 0)
        {
            Console.WriteLine("largest number <= k is {0}", nums[index]);
        }
        else
        {
            Console.WriteLine("largest number <= k is {0}", nums[-index - 2]);
        }
    }
}
