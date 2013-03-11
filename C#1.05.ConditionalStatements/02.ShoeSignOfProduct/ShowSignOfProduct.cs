using System;

class ShowSignOfProduct
{
    static void Main()
    {
        int length = 3;
        Console.WriteLine("Enter {0} numebrs (on separate lines):", length);
        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            if (int.TryParse(Console.ReadLine(), out array[i]) != true)
            {
                Console.WriteLine("Invalid number!");
                return;
            }
        }
        if (array[0] != 0 && array[1] != 0 && array[2] != 0)
        {
            if (array[0] < 0)
            {
                if (array[1] < 0)
                {
                    if (array[2] < 0)
                    {
                        Console.WriteLine("Product is negative");
                    }
                    else
                    {
                        Console.WriteLine("Product is positive");
                    }
                }
                else
                {
                    if (array[2] < 0)
                    {
                        Console.WriteLine("Product is positive");
                    }
                    else
                    {
                        Console.WriteLine("Product is negative");
                    }
                }
            }
            else
            {
                if (array[1] < 0)
                {
                    if (array[2] < 0)
                    {
                        Console.WriteLine("Product is positive");
                    }
                    else
                    {
                        Console.WriteLine("Product is negative");
                    }
                }
                else
                {
                    if (array[2] < 0)
                    {
                        Console.WriteLine("Product is negative");
                    }
                    else
                    {
                        Console.WriteLine("Product is positive");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("product is zero");
        }

    }
}