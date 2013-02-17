using System;

class Problem04
{
    static void Main()
    {
        Console.Write("enter hexadecimal number: ");
        string hex = Console.ReadLine();
        //string hex = "A15FF";

        int num = 0;
        int n = 1;
        foreach (char digit in hex)
        {
            int temp = 0;
            switch (digit)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9': temp = digit; break;
                case 'a':
                case 'A': temp = 10 + '0'; break;
                case 'b':
                case 'B': temp = 11 + '0'; break;
                case 'c':
                case 'C': temp = 12 + '0'; break;
                case 'd':
                case 'D': temp = 13 + '0'; break;
                case 'e':
                case 'E': temp = 14 + '0'; break;
                case 'f':
                case 'F': temp = 15 + '0'; break;
                default: break;
            }
            num += (temp - '0') * (int)Math.Pow(16, hex.Length - n);
            n++;
            
        }

        Console.WriteLine("it's decimal representation: {0}", num);
    }
}
