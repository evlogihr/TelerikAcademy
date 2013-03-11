using System;

class P06
{
    static void Main()
    {
        Console.Write("Enter numbers separated by \" \": ");
        string strInput = Console.ReadLine();
        
        //string strInput = "43 68 9 23 318";

        string[] strNum = strInput.Split(' ');
        int sum = 0;
        for (int i = 0; i < strNum.Length; i++)
        {
            sum += int.Parse(strNum[i]);
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}
