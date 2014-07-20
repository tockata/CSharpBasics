// Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.

using System;

class PrimeChecker
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        bool result = isPrime(n);
        Console.WriteLine(result);
    }

    private static bool isPrime(long n)
    {
        bool result = true;
        if (n == 0 || n == 1)
        {
            result = false;
            return result;
        }
        else
        {
            for (int i = 2; i <= (int)Math.Ceiling(Math.Sqrt(n)); i++)
            {
                if (i != n && n % i == 0)
                {
                    result = false;
                }
            }
        }
        return result;
    }
}