// Write a program that finds the biggest of three numbers.

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double biggestNumber = a;

        if (b > a)
        {
            biggestNumber = b;
        }
        if (c > b && c > a)
        {
            biggestNumber = c;
        }
        Console.WriteLine(biggestNumber);
    }
}