// Write a program that gets two numbers from the console and prints the greater of them. 
// Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        double greaterNumber = (a > b) ? a : b;

        Console.WriteLine("Greater number is: {0}", greaterNumber);
    }
}