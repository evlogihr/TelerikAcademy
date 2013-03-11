using System;
   
class Fibonacci
{
    static void Main()
    {
        ulong a = 0;
        ulong b = 1;
        ulong c = 0;
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(c);
            a = b;
            b = c;
            c = a + b;
        }
    }
}