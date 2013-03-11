using System;

class Program
{
    static void Main()
    {
        string FirstName;
        string FamilyName;
        byte Age;
        char Gender;
        int IDnum;
        int UENum;
        Console.Write("Type in the employe's first name: ");
        FirstName = Console.ReadLine();
        Console.Write("Type in the employe's family name: ");
        FamilyName = Console.ReadLine();
        Console.Write("Type in the employe's age: ");
        Age = byte.Parse(Console.ReadLine());
        Console.Write("Type in the employe's gender (m/f): ");
        Gender = char.Parse(Console.ReadLine());
        Console.Write("Type in the employe's ID number: ");
        IDnum = int.Parse(Console.ReadLine());
        Console.Write("Type in the unique employe number: ");
        UENum = int.Parse(Console.ReadLine());
        Console.WriteLine("\n The entered employe is \n {0}, {1} year old \n ID number: {3} \n Employe number: {4}", FirstName + " " + FamilyName, Age, Gender, IDnum, UENum);
    }
}
