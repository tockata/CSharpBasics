// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// Calculates the sum of the digits (in our example 2+0+1+1 = 4).
// Prints on the console the number in reversed order: dcba (in our example 1102).
// Puts the last digit in the first position: dabc (in our example 1201).
// Exchanges the second and the third digits: acbd (in our example 2101).
// The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main()
    {
        // First solution:
        Console.Write("Enter four digit number: ");
        int number = int.Parse(Console.ReadLine());
        int a = (number / 1000) % 10;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;

        int sum = a + b + c + d;
        Console.WriteLine("The sum of the digits = {0}", sum);
        Console.WriteLine(d + "" + c + "" + b + "" + a);
        Console.WriteLine(d + "" + a + "" + b + "" + c);
        Console.WriteLine(a + "" + c + "" + b + "" + d);
        
        // Second solution:
        //Console.Write("Enter four digit number: ");
        //string input = Console.ReadLine();
        //int[] digits = new int[input.Length];
        //int sum2 = 0;

        //for (int i = 0; i < digits.Length; i++)
        //{
        //    digits[i] = (int)Char.GetNumericValue(input[i]);
        //    sum2 += digits[i];
        //}
        //Console.WriteLine("The sum of the digits = {0}", sum2);

        //for (int i = digits.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(digits[i]);
        //}
        //Console.WriteLine();

        //string dabc = input[3] + "" + input[0] + "" + input[1] + "" + input[2];
        //string acbd = input[0] + "" + input[2] + "" + input[1] + "" + input[3];
        //Console.WriteLine(dabc);
        //Console.WriteLine(acbd);
    }
}