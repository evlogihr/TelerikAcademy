using System;

class Problem14
{
    static void Swap(string[] arr, int left, int right) //swap 2 elements of an array
    {
        string temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
    }

    static void Partition(string[] arr, int start, int end) //start and end of the segment being analized
    {
        int length = end - start;
        if (length < 2)
        {
            return;
        }
        int pivot = start + (length / 2);
        int low = start, up = end;
        while (low < up) //stops the loop when low = up = pivot
        {
            low = start;
            up = end;
            while (string.Compare(arr[low], arr[pivot]) == -1) //find the first element >= pivot on the left side of the pivot
            {
                low++;
            }
            while (string.Compare(arr[up], arr[pivot]) == 1) //find the first element <= pivot on right side of the pivot
            {
                up--;
            }
            Swap(arr, low, up);//swap the two elements found
        }
        Partition(arr, start, pivot); //recursive call of the method for the left side

        Partition(arr, pivot + 1, end); //recursive call of the method for the right side
    }

    static void Main()
    {
        //input
        string[] arr = { "us", "fa", "ac", "vee", "ad", "rde", "wff", "ng", "ih", "jk" };

        Partition(arr, 0, arr.Length - 1);

        //print result
        Console.WriteLine(string.Join(", ", arr));
    }
}
