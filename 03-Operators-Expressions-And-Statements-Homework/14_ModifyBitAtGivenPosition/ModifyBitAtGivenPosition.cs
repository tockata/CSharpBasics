// We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p
// from the binary representation of n while preserving all other bits in n.

using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit value: ");
        int v = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int numberAndMask = n & mask;
        int bit = numberAndMask >> p;

        if (bit != v)
        {
            if (v == 1)
            {
                n = n | mask;
            }
            else if (v == 0)
            {
                n = n & ~mask;
            }
        }
        Console.WriteLine("n = {0}", n);
    }
}