// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. Use the Euclidean algorithm (find it in Internet).

using System;

class CalculateGreatestCommonDivisor
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int remainder = int.MaxValue;

        while (remainder != 0)
        {
            remainder = a % b;
            a = b;
            b = remainder;
        }
        Console.WriteLine("Greatest common divisor is: {0}", a);
    }
}