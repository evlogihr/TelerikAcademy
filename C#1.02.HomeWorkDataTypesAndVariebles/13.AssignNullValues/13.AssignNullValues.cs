using System;

class Program
{
    static void Main()
    {
        int? IntVariable = null;
        double? DoubleVariable = null;
        IntVariable = IntVariable + 10;
        Console.WriteLine("The Integer value is :_{0}_ and the Double value is:_{1}_",IntVariable,DoubleVariable);
        Console.WriteLine("The sum of the Int and 10 is {0}",DoubleVariable+10);
    }
}
