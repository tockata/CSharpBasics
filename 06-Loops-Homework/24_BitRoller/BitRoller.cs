using System;

class BitRoller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        int frozenBit = (n >> f) & 1;

        for (int i = 0; i < r; i++)
        {
            int lastBit = n & 1;
            n = n >> 1;
            if (lastBit == 1)
            {
                int mask = 1 << 18;
                n = n | mask;
            }
            else if (lastBit == 0)
            {
                int mask = ~ (1 << 18);
                n = n & mask;
            }

            int bitAtFPosition = (n >> f) & 1;
            if (f == 0)
            {
                if (frozenBit == 1)
                {
                    n = n ^ (1 << f);
                    n = n & ~(1 << 18);
                }
                else if (frozenBit == 0)
                {
                    n = n & ~(1 << f);
                    n = n ^ (1 << 18);
                }
            }
            else if (frozenBit != bitAtFPosition)
            {
                if (frozenBit == 1)
                {
                    n = n ^ (1 << f);
                    n = n & ~(1 << (f - 1));
                }
                else if (frozenBit == 0)
                {
                    n = n & ~(1 << f);
                    n = n ^ (1 << (f - 1));
                }
            }
        }
        Console.WriteLine(n);
    }
}