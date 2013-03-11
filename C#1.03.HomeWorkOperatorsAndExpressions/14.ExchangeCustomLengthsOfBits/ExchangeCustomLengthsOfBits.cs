using System;

class ExchangeCustomLengthsOfBits
{
    static void Main()
    {
        Console.Write("Type in a positive number: ");
        string strNum = Console.ReadLine();
        uint num = 0;
        if (uint.TryParse(strNum, out num) == true)
        {
            Console.Write("Enter p = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter q = ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Enter k = ");
            int k = int.Parse(Console.ReadLine());
            if (p + k <= 32 || q + k <= 32)
            {
                int mask = 0;
                for (int i = 0; i < k; i++)
                {
                    mask = mask | (1 << i);
                }
                uint maskOne = (uint)mask << p;
                uint maskTwo = (uint)mask << q;
                uint maskOneNum = (num & Math.Min(maskOne, maskTwo)) << Math.Abs(p - q); //take bits and shift them to needed position
                uint maskTwoNum = (num & Math.Max(maskOne, maskTwo)) >> Math.Abs(p - q);
                num = num & ~(maskOne | maskTwo); //erase the existing bits
                num = num | (maskOneNum | maskTwoNum); //replace empty bits with masks
                //For checking errors!
                //Console.WriteLine("maskOne: {0}", maskOne);
                //Console.WriteLine("maskTwo: {0}", maskTwo);
                //Console.WriteLine("maskOneNum: {0}", maskOneNum);
                //Console.WriteLine("maskTwoNum: {0}", maskTwoNum);
                Console.WriteLine("the new number is: {0}", num);
            }
            else
            {
                Console.WriteLine("Values exceeds uint bits (32)");
            }
        }
        else
        {
            Console.WriteLine("{0} is not a valid number!", strNum);
        }
    }
}