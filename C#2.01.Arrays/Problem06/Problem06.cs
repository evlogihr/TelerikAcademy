using System;

class Problem06
{
    static void Main()
    {
        //read input
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        //for easy checking comment all the above and use this
        //int[] nums = { 1, 2, 3, 4, 2, 1, 4 };
        //int n = nums.Length;
        //int k = 3;

        Array.Sort(nums);
        int sum = 0;

        //find and print result
        Console.Write("Maximum sum: ");
        for (int i = 1; i <= k; i++)
        {
            sum += nums[n - i];
            if (i < k)
            {
                
                Console.Write("{0} + ", nums[n - i]);
            }
            else
            {
                Console.Write("{0}", nums[n - i]);
            }
        }
        Console.WriteLine(" = {0}", sum);
    }
}
