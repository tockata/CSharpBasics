// Write a method that calculates all prime numbers in given range and returns them as list of integers.

using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        List<int> primeNumbers = new List<int>();
        primeNumbers = FindPrimesInRange(startNum, endNum, primeNumbers);

        if (primeNumbers.Count == 0)
        {
            Console.WriteLine("(empty list)");
        }
        else
        {
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                if (i < primeNumbers.Count - 1)
                {
                    Console.Write(primeNumbers[i] + ", ");
                }
                else
                {
                    Console.WriteLine(primeNumbers[i]);
                }
            }
        }
    }

    private static List<int> FindPrimesInRange(int startNum, int endNum, List<int> primeNumbers)
    {
        for (int i = startNum; i <= endNum; i++)
        {
            bool isPrime = true;
            if (endNum <= 1)
            {
                return primeNumbers;
            }
            if (i == 0 || i == 1)
            {
                continue;
            }
            for (int j = 2; j <= (int)Math.Ceiling(Math.Sqrt(i)); j++)
			{			 			
                if (i != j && i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primeNumbers.Add(i);
            }
        }
        return primeNumbers;
    }
}