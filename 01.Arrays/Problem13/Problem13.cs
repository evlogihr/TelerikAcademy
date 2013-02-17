using System;

class Problem13
{
    static void Split(int[] arr) //split an array into subarrays
    {
        if (arr.Length < 2) 
        {
            return; //stop recursion if array length < 2
        }
        int n = arr.Length / 2;
        int[] arrA = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrA[i] = arr[i];
        }
        int[] arrB = new int[arr.Length - n];
        for (int i = n; i < arr.Length; i++)
        {
            arrB[i - n] = arr[i];
        }
        Split(arrA); //recursiv call to split the subarrays into even smaller arrays
        Split(arrB);

        Merge(arr, arrA, arrB); //when array length = 1, start sorting the arrays element by element
    }

    static void Merge(int[] arr, int[] arrA, int[] arrB) //arrA and arrB are the subarrays
    {
        int a = 0, b = 0, c = 0; //used for indexing
        while (a < arrA.Length && b < arrB.Length) //stop loop if any index out of range
        {
            if (arrA[a] < arrB[b])
            {
                arr[c] = arrA[a];
                a++;
                c++;
            }
            else
            {
                arr[c] = arrB[b];
                b++;
                c++;
            }
        }
        while (c < arr.Length) //insert the last remaining digits
        {
            if (a < arrA.Length)
            {
                arr[c] = arrA[a];
                a++;
                c++;
            }
            else if (b < arrB.Length)
            {
                arr[c] = arrB[b];
                b++;
                c++;
            }
        }
    }



    static void Main()
    {
        //DateTime start = DateTime.Now; //to mesure speed
        int[] arr = { 5, 1, 86, 6, 9, 37, 41, 2, 16, 49, 68, 25, 13, 84, 96, 51, 34, 48, 61, 55, 29 };
        //int[] arr = { 12, 21, 13, 4, 15, 6, 27, 8, 19, 10 };
        Split(arr);

        //Console.WriteLine(DateTime.Now - start); //to mesure speed
        Console.WriteLine(string.Join(", ", arr));
    }
}
