using System;

class Program
{
    static void Main()
    {
        string FirstName;
        string MiddleName;
        string LastName;
        int Balance;
        string BankName;
        string IBAN;
        string BIC;
        string CCard1; //although it is a number it's not used in mathematical equasions
        string CCard2; //so can be stored as a string as its defualt value is null if not given another value
        string CCard3;
        Console.Write("Type in the customer's first name: ");
        FirstName = Console.ReadLine();
        Console.Write("Type in the customer's middle name: ");
        MiddleName = Console.ReadLine();
        Console.Write("Type in the customer's last name: ");
        LastName = Console.ReadLine();
        string HolderName = FirstName + " " + MiddleName + " " + LastName;
        Console.Write("Type in the customer's amount of available money: ");
        Balance = int.Parse(Console.ReadLine());
        Console.Write("Type in the bank name: ");
        BankName = Console.ReadLine();
        Console.Write("Type in the customer's IBAN: ");
        IBAN = Console.ReadLine();
        Console.Write("Type in the customer's BIC: ");
        BIC = Console.ReadLine();
        Console.Write("Type in the customer's first Credit Card Number: ");
        CCard1 = Console.ReadLine();
        Console.Write("Type in the customer's second Credit Card Number: ");
        CCard2 = Console.ReadLine();
        Console.Write("Type in the customer's third Credit Card Number: ");
        CCard3 = Console.ReadLine();
    }
}
