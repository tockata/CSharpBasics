using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger fibonacciNumber = Fib(n);
        Console.WriteLine(fibonacciNumber);
    }

    private static BigInteger Fib(int n)
    {
        BigInteger firstFibonacciNumber = 1;
        BigInteger secondFibonacciNumber = 1;
        BigInteger nFibonacciNumber = 0;
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            for (int i = 2; i <= n; i++)
            {
                nFibonacciNumber = firstFibonacciNumber + secondFibonacciNumber;
                firstFibonacciNumber = secondFibonacciNumber;
                secondFibonacciNumber = nFibonacciNumber;
            }
        }
        return nFibonacciNumber;
    }
}