using System;

class CardsFromDeck
{
    static void Main()
    {
        for (int cardNum = 1; cardNum < 14; cardNum++)
        {
            for (int color = 0; color < 4; color++)
            {
                switch (cardNum)
                {
                    case 1:
                        Console.Write("Ace");
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.Write(cardNum);
                        break;
                    case 11:
                        Console.Write("Jack");
                        break;
                    case 12:
                        Console.Write("Queene");
                        break;
                    case 13:
                        Console.Write("King");
                        break;
                    default:
                        break;
                }
                switch (color)
                {
                    case 0:
                        Console.WriteLine(" of hearts");
                        break;
                    case 1:
                        Console.WriteLine(" of diamonds");
                        break;
                    case 2:
                        Console.WriteLine(" of spades");
                        break;
                    case 3:
                        Console.WriteLine(" of clubs");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
