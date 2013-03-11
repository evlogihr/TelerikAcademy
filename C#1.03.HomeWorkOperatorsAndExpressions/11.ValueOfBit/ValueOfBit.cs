using System;

class ValueOfBit
{
    static void Main()
    {
        Console.Write("Type in a number i = ");
        string strNum = Console.ReadLine();
        int num = 0;
        if (int.TryParse(strNum, out num) == true)
        {
            Console.Write("bit position b = ");
            string strBitPosition = Console.ReadLine();
            int bitPosition = 0;
            if (int.TryParse(strBitPosition, out bitPosition) == true)
            {
                int mask = 1 << bitPosition;
                int numMask = num & mask;
                int bit = numMask >> bitPosition;
                Console.WriteLine("value = {0}", bit);
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