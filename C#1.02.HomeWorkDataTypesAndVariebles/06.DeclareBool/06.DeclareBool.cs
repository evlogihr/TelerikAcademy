using System;

class DeclareChar
{
    static void Main()
    {
        Console.Write("What gender are you (male/female): ");
        string gender = Console.ReadLine();
        string fem = "female";
        bool isFemale = (gender == fem);
        Console.WriteLine("The notion that your are female is {0}.", isFemale);
    }
}