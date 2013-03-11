using System;

class Problem05
{
    static bool CheckIfBigger(int num, int[] arr)
    {
        if (num + 1 < arr.Length && num - 1 >= 0 && arr[num] > arr[num - 1] && arr[num] > arr[num + 1])
        {
            return true;
        }
        return false;
    }

    static void Main()
    {
        //while (true)
        //{
            int[] nums = { 11, 2, 5, 9, 4, 3, 6, 9, 4, 6, 5, 8, 1, 2, 8, 4, 6, 2, 88, 45, 8, 4, 2, 56, 94 };
            Console.Write("enter index = ");
            int index = int.Parse(Console.ReadLine());

            if (CheckIfBigger(index, nums))
            {
                Console.WriteLine("the element at index {0} is BIGGER than its neighbors", index);
            }
            else
            {
                Console.WriteLine("the element at index {0} is NOT bigger than its neighbors", index);
            }
        //}
    }
}
