// Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
// the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;
        double avg;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (number < min)
            {
                min = number;
            }
            else if (number > max)
            {
                max = number;
            }
        }
        avg = (double)sum / n;

        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:f2}", avg);
    }
}