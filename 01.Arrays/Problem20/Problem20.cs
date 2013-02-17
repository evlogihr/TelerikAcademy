using System;

class Problem20
{
    static void Main()
    {
        //same as with numeral systems, but starts from 1 to n, then adds to the next element

        //read input
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < Math.Pow(n, k); i++)
        {
            int[] num = new int[k];
            int comb = i;
            for (int j = k - 1; j >= 0; j--)
            {
                num[j] = comb % n + 1; 
                comb = comb / n;
            }

            //print result
            Console.Write("{0}", num[0]);
            for (int j = 1; j < k; j++)
            {
                Console.Write(", {0}", num[j]);
            }
            Console.WriteLine("");
        }
    }
}
