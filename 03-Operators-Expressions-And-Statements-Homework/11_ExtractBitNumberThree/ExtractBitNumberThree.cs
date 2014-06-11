// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. 
// The bits are counted from right to left, starting from bit #0. 
// The result of the expression should be either 1 or 0.

using System;

class ExtractBitNumberThree
{
    static void Main()
    {
        Console.Write("Enter unsigned integer: ");
        uint number = uint.Parse(Console.ReadLine());

        uint mask = 1 << 3;
        uint numberAndMask = number & mask;
        uint result = numberAndMask >> 3;

        Console.WriteLine("The third bit in number {0} is {1}.", number, result);
    }
}