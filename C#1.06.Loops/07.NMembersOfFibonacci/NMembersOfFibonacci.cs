using System;

    class NMembersOfFibonacci
    {
        static void Main()
        {
            int n;
            string consoleInput;
            int a = 0;
            int b = 1;
            int sum = a + b;
            do
            {
                Console.Write("n = ");
                consoleInput = Console.ReadLine();
            } while (!int.TryParse(consoleInput, out n));
            for (int i = 0; i < n; i++)
            {
                b = a + b;
                a = b - a;
                sum += b;
            }
            Console.WriteLine("sum = {0}", sum);
        }
    }
