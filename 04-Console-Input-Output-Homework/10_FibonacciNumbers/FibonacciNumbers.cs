//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
// (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
// Note that you may need to learn how to use loops.

using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstFibonacciNumber = 0;
        int secondFibonacciNumber = 1;
        int thirdFibonacci;

        Console.WriteLine("The first {0} Fibonacci numbers are:", n);

        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                if (i < n)
                {
                    Console.Write(firstFibonacciNumber + ",");
                }
                else if (i == n)
                {
                    Console.Write(firstFibonacciNumber);
                }
                
            }
            else if (i == 2)
            {
                if (i < n)
                {
                    Console.Write(secondFibonacciNumber + ",");
                }
                else if (i == n)
                {
                    Console.Write(secondFibonacciNumber);
                }
            }
            else
            {
                thirdFibonacci = firstFibonacciNumber + secondFibonacciNumber;
                firstFibonacciNumber = secondFibonacciNumber;
                secondFibonacciNumber = thirdFibonacci;
                if (i < n)
                {
                    Console.Write(thirdFibonacci + ",");
                }
                else if (i == n)
                {
                    Console.Write(thirdFibonacci);
                }
            }
        }
        Console.WriteLine();
    }
}
