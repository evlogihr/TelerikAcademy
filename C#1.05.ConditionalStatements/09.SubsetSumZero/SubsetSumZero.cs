using System;

class SubsetSumZero
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers on separate lines:");
        int[] array = new int[5];
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        byte n = 0;
        for (int i = 0; i < 5; i++)
        {
            sum = array[i];
            if (sum == 0)
            {
                Console.WriteLine("{0} = {2}", array[i], sum);
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                sum = array[i] + array[j];
                if (sum == 0)
                {
                    Console.WriteLine("{0} + {1} = {2}", array[i], array[j], sum);
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                for (int k = j + 1; k < 5; k++)
                {
                    sum = array[i] + array[j] + array[k];
                    if (sum == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = {3}", array[i], array[j], array[k], sum);
                    }
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                for (int k = j + 1; k < 5; k++)
                {
                    for (int l = k + 1; l < 5; l++)
                    {
                        sum = array[i] + array[j] + array[k] + array[l];
                        if (sum == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", array[i], array[j], array[k], array[l], sum);
                        }
                    }
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                for (int k = j + 1; k < 5; k++)
                {
                    for (int l = k + 1; l < 5; l++)
                    {
                        for (int m = l + 1; m < 5; m++)
                        {
                            sum = array[i] + array[j] + array[k] + array[l] + array[m];
                            if (sum == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", array[i], array[j], array[k], array[l], array[m], sum);
                            }
                        }
                    }
                }
            }
        }
    }
}
