// Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long. 
// The output should be a variable of type string. Do not use the built-in .NET functionality.

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long numberInDecimal = long.Parse(Console.ReadLine());
        long result = numberInDecimal;
        string output = "";

        while (result > 0)
        {
            result = numberInDecimal / 16;
            long digitInHex = numberInDecimal % 16;
            numberInDecimal = result;

            switch (digitInHex)
            {
                case 0: output = digitInHex.ToString() + "" + output; break;
                case 1: output = digitInHex.ToString() + "" + output; break;
                case 2: output = digitInHex.ToString() + "" + output; break;
                case 3: output = digitInHex.ToString() + "" + output; break;
                case 4: output = digitInHex.ToString() + "" + output; break;
                case 5: output = digitInHex.ToString() + "" + output; break;
                case 6: output = digitInHex.ToString() + "" + output; break;
                case 7: output = digitInHex.ToString() + "" + output; break;
                case 8: output = digitInHex.ToString() + "" + output; break;
                case 9: output = digitInHex.ToString() + "" + output; break;
                case 10: output = 'A' + "" + output; break;
                case 11: output = 'B' + "" + output; break;
                case 12: output = 'C' + "" + output; break;
                case 13: output = 'D' + "" + output; break;
                case 14: output = 'E' + "" + output; break;
                case 15: output = 'F' + "" + output; break;
                default: break;
            }
        }
        Console.WriteLine(output);
    }
}