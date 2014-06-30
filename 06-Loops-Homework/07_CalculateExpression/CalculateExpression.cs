// Calculate N! / (K! * (N-K)!)
// In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations)
// is calculated by the following formula:N! / (K! * (N-K)!)
// For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

class CalculateExpression
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNMinusK = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;

            if (i <= k)
            {
                factorialK *= i;
            }
            if (i <= (n - k))
            {
                factorialNMinusK *= i;
            }
        }
        BigInteger result = factorialN / (factorialK * factorialNMinusK);
        Console.WriteLine(result);
    }
}