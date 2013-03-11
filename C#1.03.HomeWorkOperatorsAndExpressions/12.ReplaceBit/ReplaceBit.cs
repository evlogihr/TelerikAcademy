using System;

class ReplaceBit
{
    static void Main()
    {
        Console.Write("Type in a number n = ");
        string strNum = Console.ReadLine();
        int num = 0;
        if (int.TryParse(strNum, out num) == true)
        {
            Console.Write("bit position p = ");
            string strBitPosition = Console.ReadLine();
            int bitPosition = 0;
            if (int.TryParse(strBitPosition, out bitPosition) == true)
            {
                Console.Write("bit value v = ");
                string strBitValue = Console.ReadLine();
                int bitValue = 0;
                if (int.TryParse(strBitValue, out bitValue) == true)
                {
                    if (bitValue == 1)
                    {
                        int mask = 1 << bitPosition;
                        int numMask = num | mask;
                        Console.WriteLine("n = {0}", numMask);
                    }
                    else
                    {
                        int mask = ~(1 << bitPosition);
                        int numMask = num & mask;
                        Console.WriteLine("n = {0}", numMask);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is not a valid number!", strBitValue);
                }
            }
            else
            {
                Console.WriteLine("{0} is not a valid number!", strBitPosition);
            }
        }
        else
        {
            Console.WriteLine("{0} is not a valid number!", strNum);
        }
    }
}
