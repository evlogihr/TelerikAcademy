using System;

class P04
{
    static void ThreeSides()
    {
        Console.Write("enter side a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("enter side b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("enter side c = ");
        double c = double.Parse(Console.ReadLine());

        double s = (a + b + c) / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        Console.WriteLine("the area is: {0}", area);
    }

    static void TwoSidesAngle()
    {
        Console.Write("enter side a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("enter side b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("enter angle = ");
        double angle = double.Parse(Console.ReadLine());

        double area = a * b * Math.Sign(angle) / 2;

        Console.WriteLine("the area is: {0}", area);
    }

    static void SideAltitude()
    {
        Console.Write("enter side: ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("enter altitude: ");
        double alt = double.Parse(Console.ReadLine());

        Console.WriteLine("the area is: {0}", side * alt / 2);
    }

    static void Main()
    {
        Console.WriteLine("1. for side and altitude to it");
        Console.WriteLine("2. for 2 sides and an angle between them");
        Console.WriteLine("3. for three sides");
        Console.Write("enter your choice: ");
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1: SideAltitude(); break;
            case 2: TwoSidesAngle(); break;
            case 3: ThreeSides(); break;
            default: break;
        }
    }
}