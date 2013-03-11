using System;

class InputIntDoubleOrString
{
    static void Main()
    {
        Console.Write("What type of variable will you enter (int,double or string)?");
        string type = Console.ReadLine();
        switch (type)
        {
            case "int":
                Console.Write("Enter integer: ");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", integer + 1);
                break;
            case "double":
                Console.Write("Enter double: ");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", number + 1);
                break;
            case "string":
                Console.Write("Enter string: ");
                string str = Console.ReadLine();
                Console.WriteLine("Result: {0}*", str);
                break;
            default:
                Console.WriteLine("Invalid entry!");
                break;
        }

    }
}