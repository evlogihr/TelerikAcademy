using System;

class QuadraticEquasion
{
    static void Main()
    {
        double a = 0;
        double b = 0;
        double c = 0;
        Console.WriteLine("ax2 + bx + c = 0");
        Console.Write("Enter a = ");
        string strA = Console.ReadLine();
        if (double.TryParse(strA, out a) == true)
        {
            Console.Write("Enter b = ");
            string strB = Console.ReadLine();
            if (double.TryParse(strB, out b) == true)
            {
                Console.Write("Enter c = ");
                string strC = Console.ReadLine();
                if (double.TryParse(strC, out c) == true)
                {
                    double determinant = b * b - 4 * a * c;
                    if (determinant >= 0)
                    {
                        if (determinant == 0)
                        {
                            double x = (- b )/(2*a);
                            Console.WriteLine("There is only one root X = {0:0.0000}", x);
                        }
                        else
                        {
                            double x1 = (- b - Math.Sqrt(determinant)) / (2 * a);
                            double x2 = (- b + Math.Sqrt(determinant)) / (2 * a);
                            Console.WriteLine("There are two roots X1 = {0:0.0000}, X2 = {1:0.0000}", x1, x2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("There are no real roots to the problem!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}