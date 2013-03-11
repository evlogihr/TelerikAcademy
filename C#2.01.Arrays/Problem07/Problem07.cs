using System;

class Problem07
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
        //int[] nums = { 15, 24, 0, 3, 6, 49, -7, 2, -14, 3, 21, -8, 1 };
        //int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            int minNum = nums[i];
            int position = i;
            for (int j = i + 1; j < n; j++)
            {
                //find smallest element of the remaining
                if (nums[j] < minNum) 
                {
                    minNum = nums[j];
                    position = j;
                }
            }

            //put smallest in position
            int temp = nums[i];
            nums[i] = nums[position];
            nums[position] = temp;
        }

        //print result
        string numStr = string.Join(", ", nums);
        Console.WriteLine("Sorted array: {0}", numStr);
    }
}
