// Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int number = int.Parse(Console.ReadLine());
        bool result = false;

        if ((number / 100) % 10 == 7)
        {
            result = true;
            Console.WriteLine("The third digit of the number from right to left is 7? {0}", result);
        }
        else
        {
            Console.WriteLine("The third digit of the number from right to left is 7? {0}", result);
        }
    }
}