// Write a program to calculate the nth Catalan number by given n (1 < n < 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger factorial2N = 1;
        BigInteger factorialNPlusOne = 1;
        BigInteger factorialN = 1;

        for (int i = 1; i <= n * 2; i++)
        {
            factorial2N *= i;
            if (i <= n + 1)
            {
                factorialNPlusOne *= i;
            }
            if (i <= n)
            {
                factorialN *= i;
            }
        }
        BigInteger result = factorial2N / (factorialNPlusOne * factorialN);
        Console.WriteLine(result);
    }
}