// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
// Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. 
// Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;

class ComparingFloats
{
    static void Main()
    {
        double constant = 0.000001;
        Console.WriteLine("Enter number floating-point numbers a and b:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        if (Math.Abs(a - b) <= constant)
        {
            Console.WriteLine("a = b");
        }
        else
        {
            Console.WriteLine("a != b");
        }
    }
}