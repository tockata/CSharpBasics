// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. 
// Use a sequence of if operators.

using System;

class MultiplicationSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine("-");
        }
        else if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine("-");
        }
        else if (a > 0 && b > 0 && c < 0)
        {
            Console.WriteLine("-");
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("-");
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("+");
        }
    }
}