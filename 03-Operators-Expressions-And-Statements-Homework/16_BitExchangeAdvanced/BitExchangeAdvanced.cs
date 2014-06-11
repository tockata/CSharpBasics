// Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
// The first and the second sequence of bits may not overlap.

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter unsigned integer: ");
        uint n;
        bool checkUint = uint.TryParse(Console.ReadLine(), out n);
        Console.Write("Enter start index of first bit sequence: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter start index of second bit sequence: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter number of bits to change: ");
        int k = int.Parse(Console.ReadLine());
        int tempP = p;
        int tempQ = q;
        bool check = false;

        for (int i = 0; i <= k - 1; i++)
        {
            if (tempP > 31 || tempQ > 31 || tempP < 0 || tempQ < 0 || checkUint == false)
            {
                check = true;
                Console.WriteLine("out of range");
                break;
            }
            else if (tempP == q || tempQ == p)
            {
                check = true;
                Console.WriteLine("overlapping");
                break;
            }
            uint firstMask = 1u << tempP;
            uint firstNumberAndMask = n & firstMask;
            uint firstBitValue = firstNumberAndMask >> tempP;

            uint secondMask = 1u << tempQ;
            uint secondNumberAndMask = n & secondMask;
            uint secondBitValue = secondNumberAndMask >> tempQ;

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
            tempP++;
            tempQ++;
        }
        if (check == false)
        {
            Console.WriteLine("After exchange n = {0}", n);
        }
    }
}