using System;

class BonusScoreUsingSwitch
{
    static void Main()
    {
        Console.Write("Enter score [1-9]: ");
        int score = int.Parse(Console.ReadLine());
        int bonusScore = 0;
        switch (score)
        {
            case 1:
            case 2:
            case 3:
                bonusScore = score * 10;
                break;
            case 4:
            case 5:
            case 6:
                bonusScore = score * 100;
                break;
            case 7:
            case 8:
            case 9:
                bonusScore = score * 1000;
                break;
            default:
                Console.WriteLine("invalid score!");
                break;
        }
            Console.WriteLine("The bonus score = {0}", bonusScore);
    }
}
