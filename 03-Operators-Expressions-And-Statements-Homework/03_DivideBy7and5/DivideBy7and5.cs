// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DivideBy7and5
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int number = int.Parse(Console.ReadLine());
        bool result;
                
        if (number % 7 == 0 && number % 5 == 0 && number != 0)
        {
            result = true;
            Console.WriteLine("Number {0} can be devided by 7 and 5 in the same time? {1}", number, result);
        }
        else
        {
            result = false;
            Console.WriteLine("Number {0} can be devided by 7 and 5 in the same time? {1}", number, result);
        }
    }
}