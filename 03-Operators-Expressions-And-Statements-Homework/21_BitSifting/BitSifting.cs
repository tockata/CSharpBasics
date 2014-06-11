using System;

class BitSifting
{
    static void Main()
    {
        ulong numberToSieve = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int bitCount = 0;

        for (int i = 0; i < n; i++)
        {
            ulong sieve = ulong.Parse(Console.ReadLine());
            for (int j = 0; j < 64; j++)
            {
                ulong mask = 1ul << j;
                ulong sieveAndMask = sieve & mask;
                ulong resultBit = sieveAndMask >> j;
                if (resultBit == 1)
                {
                    numberToSieve = ~(1ul << j) & numberToSieve;
                }
            }
        }
        for (int i = 0; i < 64; i++)
        {
            ulong resultBit = (numberToSieve & (1ul << i)) >> i;
            if (resultBit == 1)
            {
                bitCount++;
            }
        }
        Console.WriteLine(bitCount);
    }
}