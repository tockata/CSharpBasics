// Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c
// and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
// The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form,
// padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned;
// the number c should be printed with 3 digits after the decimal point, left aligned.

using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        string binaryStringA = Convert.ToString(a, 2);
        int aInBinary = Convert.ToInt32(binaryStringA);

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("|{0,-10:X}|{1:D10}|", a, aInBinary);
        if ((b - (int)b) != 0)
        {
            Console.Write("{0,10:f2}|", b);
        }
        else if ((b - (int)b) == 0)
        {
            Console.Write("{0,10}|", b);
        }
        if ((c - (int)c) != 0)
        {
            Console.Write("{0,-10:f3}|", c);
        }
        else if ((c - (int)c) == 0)
        {
            Console.Write("{0,-10}|", c);
        }
        Console.WriteLine();
    }
}