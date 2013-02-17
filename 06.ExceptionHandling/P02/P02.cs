using System;

class P02
{
    static int ReadNumber(int start, int end)
    {
        Console.Write("enter a number in the range [{0}, {1}]: ", start + 1, end + 1);
        int num = 0;

        try
        {
            num = int.Parse(Console.ReadLine());
            if (num < start || num > end)
            {
                Console.WriteLine("Number not in range");
                return start;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Format");
        }
        catch (Exception)
        { 
        }
        return num;
    }

    static void Main()
    {
        int[] nums = new int[10];
        int start = 1;
        for (int i = 0; i < 10; i++)
        {
            nums[i] = ReadNumber(start, 99);
            start = nums[i];
        }

        Console.WriteLine(string.Join(", ", nums));
    }
}
