using System;
using System.Numerics;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger sumOfEvens = 0;
        BigInteger sumOfOdds = 0;

        for (int i = 1; i <= n * 2; i++)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                sumOfEvens += number;
            }
            else
            {
                sumOfOdds += number;
            }
        }
        if (sumOfEvens == sumOfOdds)
        {
            Console.WriteLine("Yes, sum={0}", sumOfOdds);
        }
        else
        {
            BigInteger diff = sumOfOdds - sumOfEvens;
            if (diff < 0)
            {
                diff *= -1;
            }
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}