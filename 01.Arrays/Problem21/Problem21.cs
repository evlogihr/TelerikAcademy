using System;

class Problem21
{
    static void Variation(int[] arr, int n, int index, int number)
    {
        if (index == arr.Length)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
        else
        {
            for (int i = number; i <= n; i++)
            {
                arr[index] = i;
                Variation(arr, n, index + 1, i + 1);
            }
        }
    }

    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        int[] num = new int[k];
        Variation(num, n, 0, 1);
    }
}