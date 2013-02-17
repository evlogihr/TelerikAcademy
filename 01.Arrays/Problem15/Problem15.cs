using System;

class Problem15
{
    static void Main()
    {
        int n = 10000000;
        bool[] primes = new bool[n];
        for (int i = 0; i < n; i++) //set all elements to true
        {
            primes[i] = true;
        }
        primes[0] = false; //0 not prime
        primes[1] = false; //1 not prime

        for (int i = 0; i < Math.Sqrt(n); i++)
        {
            if (primes[i])
            {
                for (int j = i*i; j < n; j += i) //set all non-prime to false
                {
                    primes[j] = false;
                }
            }
        }

        //print result
        for (int i = 0; i < n; i++)
        {
            if (primes[i])
            {
                Console.Write ("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}
