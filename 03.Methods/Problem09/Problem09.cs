using System;

class Problem09
{
    static int MaxElement(int[] arr, int start)
    {
        int maxElem = 0;
        int index = 0;
        for (int i = start; i < arr.Length; i++)
        {
            if (arr[i] > maxElem)
            {
                maxElem = arr[i];
                index = i;
            }
        }
        return index;
    }

    static void OrderArrayDesc(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int maxElemIndex = MaxElement(arr, i);
            Swap(arr, i, maxElemIndex);
        }
    }

    static void OrderArrayAsc(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            Swap(arr, i, arr.Length - 1 - i);
        }
    }

    static void Swap(int[] arr, int num1, int num2)
    {
        int temp = arr[num2];
        arr[num2] = arr[num1];
        arr[num1] = temp;
    }

    static void Main()
    {
        int[] arr = { 1, 22, 3, 24, 5, 6, 7, 28, 9, 10, 32, 15, 26, 12, 13, 21 };

        OrderArrayDesc(arr);

        Console.WriteLine("the array in descending order: ");
        Console.WriteLine(string.Join(", ", arr));

        OrderArrayAsc(arr);

        Console.WriteLine("the array in ascending order: ");
        Console.WriteLine(string.Join(", ", arr));
    }
}
