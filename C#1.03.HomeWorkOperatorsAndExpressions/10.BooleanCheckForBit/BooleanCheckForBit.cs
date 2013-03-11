using System;

class BooleanCheckForBit
{
    static void Main()
    {
        Console.Write("Type in a number v = ");
        string strNum = Console.ReadLine();
        int num = 0;
        if (int.TryParse(strNum, out num) == true)
        {
            Console.Write("bit position p = ");
            string strBitPosition = Console.ReadLine();
            int bitPosition = 0;
            if (int.TryParse(strBitPosition, out bitPosition) == true)
            {
                int mask = 1 << bitPosition;
                int numMask = num & mask;
                Console.WriteLine(((num & mask) == 0) ^ true);
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

