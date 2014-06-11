// Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit index to extract: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int numberAndMask = n & mask;
        int resultBit = numberAndMask >> p;
        Console.WriteLine("The bit at index {0} is {1}.", p, resultBit);
    }
}