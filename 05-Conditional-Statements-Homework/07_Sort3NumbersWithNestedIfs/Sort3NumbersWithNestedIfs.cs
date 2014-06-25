// Write a program that enters 3 real numbers and prints them sorted in descending order. 
// Use nested if statements. Don’t use arrays and the built-in sorting functionality.

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine(a);
            if (b > c)
            {
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
            }
        }
        if (b > a && b > c)
        {
            Console.WriteLine(b);
            if (a > c)
            {
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
        }
        if (c > a && c > b)
        {
            Console.WriteLine(c);
            if (a > b)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
        }
    }
}