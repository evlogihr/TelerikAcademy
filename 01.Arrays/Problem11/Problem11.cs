using System;

class Problem11
{
    static void Main()
    {
        //input of array not required in this problem
        int[] nums = { 5, 13, -6, -11, 2, 21, 6, 4, -8, 8, 23, -16, 0, 12, -21, 16, 14, -25, 18, 3, -26, 7, 22, -31, 9, 24, -3 };
        int n = nums.Length;
        Array.Sort(nums);
        Console.Write("Enter searched number: ");
        int searched = int.Parse(Console.ReadLine());

        int start = 0;
        int end = n - 1;
        int index = int.MinValue;
        bool exist = false;
        while (true)
        {
            int middle = (end - start) / 2;
            if (middle == 0)
            {
                break;
            }
            if (searched == nums[start + middle])
            {
                exist = true;
                index = start + middle;
                break;
            }
            else if (searched > nums[start + middle])
            {
                start += middle;
            }
            else
            {
                end -= middle;
            }
        }

        //print result
        if (exist)
        {
            Console.WriteLine("The index of {0} is {1}", searched, index);
        }
        else
        {
            if (searched < nums[0] || searched > nums[n - 1])
            {
                Console.WriteLine("Number {0} is not in the interval of the array", searched);
            }
            else
            {
                Console.WriteLine("Number {0} NOT found, should be between index {1} and {2}", searched, start, end);
            }
        }
    }
}
