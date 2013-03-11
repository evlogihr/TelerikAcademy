using System;

    class Problem04
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
            //int[] nums = { 1, 2, 2, 3, 4, 2, 2, 2, 1, 4 };
            //int n = nums.Length;

            int maxLength = 1;
            int startingElement = 0;

            for (int i = 0; i < n - 1; i++)
            {
                int length = 1;
                int element = nums[i];
                while (i < n - 1 && nums[i] == nums[i + 1])
                {
                    length++;
                    i++;
                }
                if (length > maxLength) //will take only first sequence found
                {
                    maxLength = length;
                    startingElement = element;
                }
            }

            //print result
            Console.Write("The maximal sequence of equal elements is : {");
            for (int i = 0; i < maxLength; i++)
            {
                if (i == maxLength - 1)
                {
                    Console.Write("{0}", startingElement);
                }
                else
                {
                    Console.Write("{0}, ", startingElement);
                }
            }
            Console.WriteLine("}");
        }
    }
