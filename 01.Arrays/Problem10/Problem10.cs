using System;

class Problem10
{
    static void Main()
    {
        //read input
        Console.Write("Enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array elements:");
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter sum: ");
        int s = int.Parse(Console.ReadLine());


        //for easy checking comment all the above and use this
        //int[] nums = { 5, 3, -6, -1, 2, -1, 6, 4, -8, 8, 3, -6, -1, 2, -1, 6, 4, -25, 8, 3, -6, -1, 2, -1, 6, 4, -3, 8 };
        //int[] nums = { 4, 3, 1, 4, 2, 5, 8 };
        //int n = nums.Length;
        //int s = 11;

        bool isEqual = false;
        int sum = 0;
        int length = 0;
        int startIndex = 0;
        for (int i = 0; i < n; i++)
        {
            sum = nums[i];
            startIndex = i;
            length = 1;
            for (int j = i + 1; j < n; j++)
            {
                sum += nums[j];
                length++;
                if (sum == s)
                {
                    isEqual = true;
                    break;
                }
            }
            if (isEqual)
            {
                break;
            }
        }


        //print results
        if (isEqual)
        {
        Console.Write("Sequence Found: {");
        for (int i = 0; i < length; i++)
        {
            if (i < length - 1)
            {
                Console.Write("{0}, ", nums[startIndex + i]);
            }
            else
            {
                Console.Write("{0}", nums[startIndex + i]);
            }
        }
        Console.Write("}");
        Console.WriteLine(" = {0}", s);
        }
        else
        {
            Console.WriteLine("No sequence that gives sum = {0}", s);
        }
    }
}
