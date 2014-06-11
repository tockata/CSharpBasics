// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter unsigned integer: ");
        uint n = uint.Parse(Console.ReadLine());

        for (int i = 24, j = 3; i <= 26; i++, j++)
        {
            uint firstMask = 1u << i;
            uint firstNumberAndMask = n & firstMask;
            uint firstBitValue = firstNumberAndMask >> i;

            uint secondMask = 1u << j;
            uint secondNumberAndMask = n & secondMask;
            uint secondBitValue = secondNumberAndMask >> j;

            if (firstBitValue == 0)
            {
                n = n & ~secondMask;
            }
            if (firstBitValue == 1)
            {
                n = n | secondMask;
            }
            if (secondBitValue == 0)
            {
                n = n & ~firstMask;
            }
            if (secondBitValue == 1)
            {
                n = n | firstMask;
            }
        }
        Console.WriteLine("After exchange n = {0}", n);
    }
}