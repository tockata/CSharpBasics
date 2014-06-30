// Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.

using System;
using System.Numerics;

class NFactorialDividedByKFactorial
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
        }
        Console.WriteLine(factorialN / factorialK);
    }
}