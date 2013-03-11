using System;
using System.Threading;
using System.Globalization;

class RectangleArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Type in the rectangle's width: ");
        string strWidth = Console.ReadLine();
        double width = 0;
        if (double.TryParse(strWidth, out width) == true)
        {
            Console.Write("Type in the rectangle's hight: ");
            string strHight = Console.ReadLine();
            double hight = 0;
            if (double.TryParse(strHight, out hight) == true)
            {
                double area = width * hight;
                Console.WriteLine("The rectangle's area is {0}.", area);
            }
            else
            {
                Console.WriteLine("The entered heith is not a valid number!");
            }
        }
        else
        {
            Console.WriteLine("The entered Width is not a valid number!");
        }
    }
}
