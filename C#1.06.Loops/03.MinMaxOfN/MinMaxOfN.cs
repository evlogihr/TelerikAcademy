using System;

class MinMaxOfN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} integers: ", n);
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(nums);
        int minimal = nums[0];
        int maximal = nums[n-1];
        Console.WriteLine("Minimal: {0}", minimal);
        Console.WriteLine("Maximal: {0}", maximal);
    }
}
