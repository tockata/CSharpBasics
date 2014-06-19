// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
// Note that you may need to use a for-loop.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}