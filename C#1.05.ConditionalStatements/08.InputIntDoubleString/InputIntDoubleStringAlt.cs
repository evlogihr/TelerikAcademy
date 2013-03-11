using System;

class InputIntDoubleStringAlt
{
    static void Main()
    {
        string str = Console.ReadLine();
        int intNum = 0;
        double realNum = 0;
        string type = null;
        if (int.TryParse(str, out intNum))
        {
            type = "int";
        }   
        if (double.TryParse(str, out realNum))
        {
            type = "double";
        }
        switch (type)
        {
            case "int":
                {
                    Console.WriteLine(intNum + 1);
                    break;
                }
            case "double":
                {
                    Console.WriteLine(realNum + 1);
                    break;
                }
            default:
                {
                    Console.WriteLine(str + "*");
                    break;
                }
        }
    }
}
