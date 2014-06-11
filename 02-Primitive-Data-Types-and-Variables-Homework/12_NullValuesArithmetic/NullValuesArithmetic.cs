// Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. 
// Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        Nullable<double> b = null;

        Console.WriteLine("Int a = {0}", a);
        Console.WriteLine("Double b = {0}", b);

        a = 15;
        b = 12.35;
        Console.WriteLine("Int a = {0}", a);
        Console.WriteLine("Double b = {0}", b);
    }
}   