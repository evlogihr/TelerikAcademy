using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName;
        string companyAdress;
        string companyPhone;
        string companyFax;
        string companySite;
        string managerFirstName;
        string managerLastName;
        string managerAge;
        string managerPhone;

        Console.WriteLine("Input data:");
        Console.Write("\t Company name: ");
        companyName = Console.ReadLine();
        Console.Write("\t Company adress: ");
        companyAdress = Console.ReadLine();
        Console.Write("\t Company phone: ");
        companyPhone = Console.ReadLine();
        Console.Write("\t Company fax: ");
        companyFax = Console.ReadLine();
        Console.Write("\t Company Site: ");
        companySite = Console.ReadLine();
        Console.Write("\t Manager first name: ");
        managerFirstName = Console.ReadLine();
        Console.Write("\t Manager last name: ");
        managerLastName = Console.ReadLine();
        Console.Write("\t Manager age: ");
        managerAge = Console.ReadLine();
        Console.Write("\t Manager phone: ");
        managerPhone = Console.ReadLine();
        Console.WriteLine("\n");
        Console.WriteLine("\t {0} is a software company, located in {1}. To contact our developers team call {2} or fax {3}. For more information about our producsts and services vist our website {4}. \n \t If you are interested in aplying for a job you can contact our {7} year old manager {5} {6} at {8}.", companyName, companyAdress, companyPhone, companyFax, companySite, managerFirstName, managerLastName, managerAge, managerPhone);
    }
}

