using System;


class BitFlipper
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());

        for (int i = 63; i >= 2; i--)
        {
            ulong firstBit = (number >> i) & 1;
            ulong secondBit = (number >> (i - 1)) & 1;
            ulong thirdBit = (number >> (i - 2)) & 1;
            if (firstBit == secondBit && firstBit == thirdBit)
            {
                if (firstBit == 0)
                {
                    number = number | (1ul << i);
                    number = number | (1ul << (i - 1));
                    number = number | (1ul << (i - 2));
                }
                else if (firstBit == 1)
                {
                    number = number ^ (1ul << i);
                    number = number ^ (1ul << (i - 1));
                    number = number ^ (1ul << (i - 2));
                }
                i -= 2;
            }
        }
        Console.WriteLine(number);
    }
}