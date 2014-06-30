// Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. 
// The output should be a variable of type long. Do not use the built-in .NET functionality.

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        long number = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '1')
            {
                double power = input.Length - 1 - i;
                number = number + (long)Math.Pow(2, power);
            }
        }
        Console.WriteLine(number);
    }
}