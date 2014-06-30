// Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000.
// For big numbers it takes more time to calculate the result!

using System;
using System.Numerics;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        int zeroCount = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        string factorialString = factorial.ToString();
        for (int i = factorialString.Length - 1; i >= 0; i--)
        {
            if (factorialString[i] == '0')
            {
                zeroCount++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(zeroCount);
    }
}