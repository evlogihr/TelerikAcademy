using System;

class Problem01
{
    static void Main()
    {
        //initiate
        int[] array = new int[20];

        for (int i = 0; i < 20; i++)
        {
            array[i] = i * 5;
        }

        //print
        string numbersStr = string.Join(", ", array);
        Console.WriteLine(numbersStr);

    }
}