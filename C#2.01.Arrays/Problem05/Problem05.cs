using System;

class Problem05
{
    static void Main()
    {
        //read
        Console.Write("Enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        Console.WriteLine("Enter the elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        //for easy checking comment all the above and use this
        //int[] nums = { 1, 2, 3, 4, 2, 1, 4 };
        //int n = nums.Length;

        //process
        int maxLength = 1;
        int startElement = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int length = 1;
            int element = i;
            while (i < nums.Length - 1 && nums[i] < nums[i + 1])
            {
                length++;
                i++;
            }
            if (length > maxLength) //will take only first sequence found
            {
                maxLength = length;
                startElement = element;
            }
        }

        //print
        Console.Write("{");
        for (int i = startElement; i <= startElement + maxLength - 1; i++)
        {
            if (i == startElement + maxLength - 1)
            {
                Console.Write("{0}", nums[i]);
            }
            else
            {
                Console.Write("{0}, ", nums[i]);
            }
        }
        Console.WriteLine("}");
    }
}
