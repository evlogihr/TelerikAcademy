using System;

class SwapBits
{
    static void Main()
    {
        Console.Write("Type in a positive number: ");
        string strNum = Console.ReadLine();
        uint num = 0;
        if (uint.TryParse(strNum, out num) == true)
        {
            uint maskOne = ((num & (7 << 3)) << 21); //I use 7 that is 0111 in binary
            uint maskTwo = ((num & (7 << 24)) >> 21);
            uint mask = maskOne | maskTwo;
            //4177526727 in binary is 1111 1000 1111 1111 1111 1111 1100 0111
            //with the next line I delete what is in the 3,4,5 and 24,25,26 bits
            num = num & 4177526727;
            num = num | mask;
            Console.WriteLine("the new number is: {0}", num);
        }
        else
        {
            Console.WriteLine("{0} is not a valid number!", strNum);
        }
    }
}