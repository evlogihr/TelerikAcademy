using System;
using System.Threading;
using System.Globalization;

class TrapezoidArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Type in the trapezoids side a: ");
        string strA = Console.ReadLine();
        double firstSide = 0;
        if (double.TryParse(strA, out firstSide) == true)
        {
            Console.Write("Type in the trapezoids side b: ");
            string strB = Console.ReadLine();
            double secondSide = 0;
            if (double.TryParse(strB, out secondSide) == true)
            {
                Console.Write("Type in the trapezoids height h: ");
                string strHight = Console.ReadLine();
                double hight = 0;
                if(double.TryParse(strHight, out hight) == true)
                {
                    Console.WriteLine("The trapezoids area is " + (firstSide + secondSide) / 2 * hight);
                }
                else
                {
                    Console.WriteLine("{0} is not a valid number!", strHight);
                }
            }
            else
            {
                Console.WriteLine("{0} is not a valid number!", strB);
            }
        }
        else
        {
            Console.WriteLine("{0} is not a valid number!", strA);
        }
    }
}

