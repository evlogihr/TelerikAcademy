using System;

class Problem14
{
    static int MinOfSet(int[] arr)
    {
        int minNum = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < minNum)
            {
                minNum = arr[i];
            }
        }
        return minNum;
    }

    static int MaxOfSet(int[] arr)
    {
        int maxNum = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maxNum)
            {
                maxNum = arr[i];
            }
        }
        return maxNum;
    }

    static int SumOfSet(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    static double AverageOfSet(int[] arr)
    {
        double average = (double)SumOfSet(arr) / arr.Length;
        return average;
    }

    static int ProductOfSet(int[] arr)
    {
        int product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }

    static void Main()
    {
        int[] arr = { 2, 6, 4, 15, 19, 13, 21 };
        int min = MinOfSet(arr);
        int max = MaxOfSet(arr);
        double averag = AverageOfSet(arr);
        int sum = SumOfSet(arr);
        long product = ProductOfSet(arr);

        Console.WriteLine("set: {0}", string.Join(", ", arr));
        Console.WriteLine("minimum: {0}", min);
        Console.WriteLine("maximum: {0}", max);
        Console.WriteLine("average: {0:F2}", averag);
        Console.WriteLine("sum: {0}", sum);
        Console.WriteLine("product: {0}", product);
    }
}
