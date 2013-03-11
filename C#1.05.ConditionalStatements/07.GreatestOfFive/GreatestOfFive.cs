using System;

class GreatestOfFive
{
    static void Main()
    {
        int numberOfIntegers = 5;
        Console.WriteLine("Enter {0} numbers: ", numberOfIntegers);
        int[] array = new int[numberOfIntegers];
        for (int i = 0; i < array.Length; i++)
        {
            if (int.TryParse(Console.ReadLine(), out array[i]) != true)
            {
                Console.WriteLine("Invalid number!");
                break;
            }
        }
        int max = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > array[i])
                {
                    max = array[j];
                }
            }
        }
        Console.WriteLine("Max: {0}", max);
        //OR
        Console.WriteLine("Max: " + Math.Max(array[0],Math.Max(array[1],Math.Max(array[2],Math.Max(array[3],array[4])))));
    }
}