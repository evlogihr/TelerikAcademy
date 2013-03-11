using System;
using System.Threading;
using System.Globalization;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        while(true)
        {
            Console.Write("Radius of the circle r = ");
            string strRadius = Console.ReadLine();
            double radius = 0;
            if(double.TryParse(strRadius, out radius) == true)
            {
                double area = Math.PI * Math.Pow(radius, 2);
                double perimeter = Math.PI * 2 * radius;
                Console.WriteLine("The area of the circle is {0:0.00}", area);
                Console.WriteLine("The perimeter of the circle is {0:0.00}", perimeter);
            }
            else
            {
                Console.WriteLine("{0} is a invalid number!", strRadius);
            }
            Console.WriteLine();
        }
    }
}
