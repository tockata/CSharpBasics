// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. 
// Print the result with 5 digits after the decimal point.

using System;

class CalculateExpression
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double factorial = 1;
        double xOnPower = x;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            xOnPower = Math.Pow(x, i);
            sum += factorial / xOnPower;
        }
        Console.WriteLine("{0:f5}", sum);
    }
}