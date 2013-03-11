using System;

class TextCorrispondingToNumber
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter number [0-999]: ");
            int num = int.Parse(Console.ReadLine());
            int tens = (num / 10) % 10;
            int hundreds = num / 100;
            switch (hundreds)
            {
                case 0:
                    Console.Write("");
                    break;
                case 1:
                    Console.Write("One hundred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Three hundred ");
                    break;
                case 4:
                    Console.Write("Four hundred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hundred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;
                default:
                    Console.Write("Invalid number!");
                    break;
            }
            switch (tens)
            {
                case 0:
                    if (num % 10 != 0)
	                {
                        Console.Write("and ");
                    }
                    break;
                case 1:
                    Console.Write("and ");
                    switch (num % 10)
                    {
                        case 1:
                            Console.Write("eleven");
                            break;
                        case 2:
                            Console.Write("twelve");
                            break;
                        case 3:
                            Console.Write("thirteen");
                            break;
                        case 4:
                            Console.Write("fourteen");
                            break;
                        case 5:
                            Console.Write("fifteen");
                            break;
                        case 6:
                            Console.Write("sixteen");
                            break;
                        case 7:
                            Console.Write("seventeen");
                            break;
                        case 8:
                            Console.Write("eighteen");
                            break;
                        case 9:
                            Console.Write("nineteen");
                            break;
                        default:
                            Console.Write("Invalid number!");
                            break;
                    }
                    break;
                case 2:
                    Console.Write("twenty ");
                    break;
                case 3:
                    Console.Write("thirty ");
                    break;
                case 4:
                    Console.Write("fourty ");
                    break;
                case 5:
                    Console.Write("fifty ");
                    break;
                case 6:
                    Console.Write("sixty ");
                    break;
                case 7:
                    Console.Write("seventy ");
                    break;
                case 8:
                    Console.Write("eighty ");
                    break;
                case 9:
                    Console.Write("ninety ");
                    break;
                default:
                    Console.Write("Invalid number!");
                    break;
            }
            if (tens != 1)
            {
                switch (num % 10)
                {
                    case 0:
                        if (hundreds != 0 || tens != 0)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Zero");
                        }
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    default:
                        Console.Write("Invalid number!");
                        break;
                }
            }
            else
            {
                Console.WriteLine();
            }
        Console.WriteLine();
        }
    }
}
