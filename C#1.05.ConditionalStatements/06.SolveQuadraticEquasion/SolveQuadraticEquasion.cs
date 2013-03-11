using System;

class SolveQuadraticEquasion
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients of the equasion a*x^2 + b*x + c = 0");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        double det = (b * b - 4 * a * c);
        if (det > 0)
        {
            double x1 = (-b - Math.Sqrt(det)) / (2 * a);
            double x2 = (-b + Math.Sqrt(det)) / (2 * a);
            Console.WriteLine("There are two different roots X1 = {0}, X2 = {1}", x1, x2);
        }
        else if (det == 0)
        {
            double x = (-b + Math.Sqrt(det)) / (2 * a);
            Console.WriteLine("There is only one real root X = {0}", x);
        }
        else
        {
            Console.WriteLine("There are no real roots of the equasion");
        }
    }
}
