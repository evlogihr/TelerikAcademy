using System;

class Problem19
{
    static void Permutation(int index, int[] arr)
    {
        if (index == arr.Length - 1)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
        else
        {
            for (int i = index; i < arr.Length; i++)
            {
                Swap(ref i, ref index, ref arr);
                Permutation(index + 1, arr);
                Swap(ref i, ref index, ref arr);
            }
        }
    }

    static void Swap(ref int a, ref int b, ref int[] arr)
    {
        int temp = arr[b];
        arr[b] = arr[a];
        arr[a] = temp;
    }
    
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("all permutations of {0} are:", n);

        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = i + 1;
        }

        Permutation(0, nums);
    }
}
