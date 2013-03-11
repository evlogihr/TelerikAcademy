using System;

class Problem03
{
    static void Main()
    {
        //enter data
        Console.WriteLine("Enter the length of the arrays: ");
        int n = int.Parse(Console.ReadLine());

        char[] firstArray = new char[n];
        Console.WriteLine("Enter the first array: ");
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = Convert.ToChar(Console.ReadLine());
        }

        char[] secondArray = new char[n];
        Console.WriteLine("Enter the second array: ");
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = Convert.ToChar(Console.ReadLine());
        }

        //for easy checking comment all the above and use these
        //char[] firstArray = { 'a', 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'b' };
        //char[] secondArray = { 'a', 'b', 'c', 'a', 'f', 'd', 'h', 'j', 'b' };

        //compare
        bool equal = true;
        string lexico = null;
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                if (firstArray[i] < secondArray[i])
                {
                    lexico = "first";
                }
                else
                {
                    lexico = "second";
                }
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
            Console.WriteLine("The {0} array is lexicographically first", lexico);
        }
    }
}
