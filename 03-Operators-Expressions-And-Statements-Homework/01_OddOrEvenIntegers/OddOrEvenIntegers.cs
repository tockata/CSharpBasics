// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int number = int.Parse(Console.ReadLine());
        bool odd;

        if (number % 2 == 0)
        {
            odd = false;
            Console.WriteLine("Number {0} is odd? {1}", number, odd);
        }
        else if (number % 2 != 0)
        {
            odd = true;
            Console.WriteLine("Number {0} is odd? {1}", number, odd);
        }
    }
}