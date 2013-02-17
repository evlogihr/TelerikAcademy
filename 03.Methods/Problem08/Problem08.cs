using System;

class Problem08
{
    static int MaxArrayLength(int[] arrA, int[] arrB)
    {
        if (arrA.Length > arrB.Length)
        {
            return arrA.Length + 1; //+1 in case result is larger than the initial arrays
        }
        else if (arrA.Length < arrB.Length)
        {
            return arrB.Length + 1; //+1 in case result is larger than the initial arrays
        }
        else
        {
            return arrA.Length + 1; //+1 in case result is larger than the initial arrays
        }
    }

    static void AddDigit(int[] arrC, ref int a, int sum)
    {
        arrC[a] += sum;
        if (arrC[a] > 9) //if > 9 add 1 to next digit
        {
            arrC[a] %= 10;
            arrC[a + 1] += 1;
        }
        a++;
    }

    static int[] SumTwoIntArrays(int[] arrA, int[] arrB)
    {
        int[] arrC = new int[MaxArrayLength(arrA, arrB)];

        int a = 0;
        while (a < Math.Min(arrA.Length, arrB.Length))
        {
            int sum = arrA[a] + arrB[a]; //add the two digits
            AddDigit(arrC, ref a, sum); //add the sum and checks if > 9
        }
        while (a < arrC.Length - 1)
        {
            if (a < arrA.Length)
            {
                AddDigit(arrC, ref a, arrA[a]); //add last digit if any remaining

            }
            else if (a < arrB.Length)
            {
                AddDigit(arrC, ref a, arrB[a]);
            }
        }
        return arrC;
    }

    static void ReadNumberToArray(out int[] arrA)
    {
        string strA = Console.ReadLine();
        arrA = new int[strA.Length];
        for (int i = 0; i < arrA.Length; i++)
        {
            arrA[i] = strA[i];
        }
    }

    static void Main()
    {
        //read input
        Console.Write("first number = ");
        int[] arrA;
        ReadNumberToArray(out arrA);

        Console.Write("second number = ");
        int[] arrB;
        ReadNumberToArray(out arrB);

        int[] arrC = SumTwoIntArrays(arrB, arrA);

        //print result
        Console.Write("result = ");
        for (int i = arrC.Length - 1; i >= 0; i--)
        {
            if (i != arrC.Length - 1 && arrC[i] != 0)
            {
                Console.Write(arrC[i]);
            }
        }
        Console.WriteLine();
    }
}
