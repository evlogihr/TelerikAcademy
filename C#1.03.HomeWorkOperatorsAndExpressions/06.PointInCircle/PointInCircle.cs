using System;
using System.Threading;
using System.Globalization;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("X coordinate of point A: ");
        string strX = Console.ReadLine();
        double x = 0;
        if (double.TryParse(strX, out x) == true)
        {
            Console.Write("Y coordinate of point A: ");
            string strY = Console.ReadLine();
            double y = 0;
            if (double.TryParse(strY, out y) == true)
            {
                if (Math.Sqrt(x * x + y * y) <= 5)
                {
                    Console.WriteLine("Point A ({0},{1}) is within the circle K(0,5)", x, y);
                }
                else
                {
                    Console.WriteLine("Point A ({0},{1}) is outside the circle K(0,5)", x, y);
                }
            }
            else
            {
                Console.WriteLine("{0} is not a valid number", strY);
            }
        }
        else
        {
            Console.WriteLine("{0} is not a valid number", strX);
        }
    }
}
