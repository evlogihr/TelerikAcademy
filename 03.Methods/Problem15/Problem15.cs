using System;

class Problem15
{
    static void MinOfSet<T>(T[] arr) where T : IComparable<T>
    {
        dynamic minNum = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].CompareTo(minNum) < 0)
            {
                minNum = arr[i];
            }
        }
        Console.WriteLine("minimum: {0}", minNum);
    }

    static void MaxOfSet<T>(T[] arr) where T : IComparable<T>
    {
        dynamic maxNum = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].CompareTo(maxNum) > 0)
            {
                maxNum = arr[i];
            }
        }
        Console.WriteLine("maximum: {0}", maxNum);
    }

    static void SumOfSet<T>(T[] arr)
    {
        dynamic sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("sum: {0}", sum);
    }

    static void AverageOfSet<T>(T[] arr)
    {
        dynamic sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        dynamic average = sum / arr.Length;
        Console.WriteLine("average: {0:F2}", average);
    }

    static void ProductOfSet<T>(T[] arr)
    {
        dynamic product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        Console.WriteLine("product: {0}", product);
    }

    static void Main()
    {
        //int[] arr = { 2, 6, 4, 15, 19, 13, 21 };
        //long[] arr = { 2, 6, 4, 15, 19, 13, 21 };
        //float[] arr = { 2.1f, 6.2f, 4f, 15f, 19f, 13f, 21f };
        //double[] arr = { 2.1, 6.2, 4, 15.5, 19, 13, 21 };
        decimal[] arr = { 2.1m, 6.2m, 4m, 15m, 19m, 13m, 21m };

        Console.WriteLine("set: {0}", string.Join(", ", arr));
        MinOfSet(arr);
        MaxOfSet(arr);
        AverageOfSet(arr);
        SumOfSet(arr);
        ProductOfSet(arr);
    }
}
