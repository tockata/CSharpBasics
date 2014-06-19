// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class Sumof5Numbers
{
    static void Main()
    {
        Console.Write("Enter five numbers: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        double sum = 0;

        foreach (string number in numbers)
        {
            double n = Convert.ToDouble(number);
            sum += n;
        }
        Console.WriteLine("The sum of numbers is: {0}", sum);
    }
}