using System;

class Problem05
{
    static void SortArrayByLength(string[] arr)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].Length > arr[i + 1].Length)
                { 
                    string temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        string[] arr = { "one", "thing", "am", "cool", "without", "anything!", "I", "writen" };
        SortArrayByLength(arr);

        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine();
    }
}
