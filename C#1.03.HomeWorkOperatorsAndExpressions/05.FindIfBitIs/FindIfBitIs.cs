using System;

class Program
{
    static void Main()
    {
        Console.Write("Type in a number: ");
        string strNum = Console.ReadLine();
        int num = 0;
        if (int.TryParse(strNum, out num) == true)
        {
            int p = 3;
            int mask = 1 << p;
            int numMask = num & mask;
            int bit = numMask >> p;
            Console.WriteLine("Bit 3 of this integer is {0}", bit);
        }
        else
        {
            Console.WriteLine("{0} is not a valid number!", strNum);
        }
    }
}
