// Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. 
// The output should be a variable of type long. Do not use the built-in .NET functionality.

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        long number = 0;

        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case '0': number = number + 0 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case '1': number = number + 1 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case '2': number = number + 2 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case '3': number = number + 3 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case '4': number = number + 4 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case '5': number = number + 5 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case '6': number = number + 6 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case '7': number = number + 7 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case '8': number = number + 8 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case '9': number = number + 9 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'A': number = number + 10 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'B': number = number + 11 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'C': number = number + 12 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'D': number = number + 13 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'E': number = number + 14 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'F': number = number + 15 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                default: break;
            }
        }
        Console.WriteLine(number);
    }
}