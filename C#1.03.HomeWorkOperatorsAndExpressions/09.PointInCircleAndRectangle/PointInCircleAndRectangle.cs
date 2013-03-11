using System;
using System.Threading;
using System.Globalization;

class PointInCircleAndRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Type coordinate X = ");
        string strX = Console.ReadLine();
        double x = 0;
        if (double.TryParse(strX, out x) == true)
        {
            Console.Write("Type coordinate Y = ");
            string strY = Console.ReadLine();
            double y = 0;
            if (double.TryParse(strY, out y) == true)
            {
                if (Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 3)
                {
                    if (x >= -1 && y <= 1)
                    {
                        if (x <= 5 && y >= -1)
                        {
                            Console.WriteLine("Point A({0},{1}) is within the circle K((1,1),3) and within the rectangle R", x, y);
                        }
                        else
                        {
                            Console.WriteLine("Point A({0},{1}) is within the circle K((1,1),3) and out of the rectangle R", x, y);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Point A({0},{1}) is within the circle K((1,1),3) and out of the rectangle R", x, y);
                    }
                }
                else
                {
                    Console.WriteLine("Point A({0},{1}) is out of the circle K((1,1),3)", x, y);
                }
            }
            else
            {
                Console.WriteLine("{0} is not a valid number!", strY);
            }
        }
        else
        {
            Console.WriteLine("{0} is not a valid number!", strX);
        }
    }
}

