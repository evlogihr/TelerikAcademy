using System;

class Problem06
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
        int[] nums = { 1, 2, 5, 9, 4, 3, 6, 9, 4, 6, 5, 8, 1, 2, 8, 4, 6, 2, 88, 45, 8, 4, 2, 56, 4 };
        //int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        int index = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (CheckIfBigger(i, nums))
            {
                index = i;
                break;
            }
        }

        Console.WriteLine("index = {0}", index);
    }
}
