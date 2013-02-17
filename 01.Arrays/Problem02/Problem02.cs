using System;

class Problem02
{
    static void Main()
    {
        //enter data
        Console.WriteLine("Enter the length of the arrays: ");
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        Console.WriteLine("Enter the first array: ");
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        int[] secondArray = new int[n];
        Console.WriteLine("Enter the second array: ");
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        //for easy checking comment all the above and use these
        //int[] firstArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        //int[] secondArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        //compare
        bool equal = true;
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                equal = false;
                break;
            }
        }

        //print result
        if (equal)
        {
            Console.WriteLine("The two arrays are equal");
        }
        else
        {
            Console.WriteLine("The two arrays are not equal");
        }
    }
}
