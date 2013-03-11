using System;

class Program
{
    static void Main()
    {
        for (int i=0; i <= 255; i ++)
        {
            string asciichar = char.ConvertFromUtf32(i);
            Console.WriteLine("In ASCII the number {0} coresponds to {1}",i,asciichar);
        }
    }
}
