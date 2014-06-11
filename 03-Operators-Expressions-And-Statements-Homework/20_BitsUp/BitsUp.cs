using System;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int bitToChange = 6;

        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 7; j >= 0; j--)
            {
                if (j == bitToChange)
                {
                    number = number | (1 << j);
                    bitToChange -= step;
                }
            }
            if (bitToChange < 0)
            {
                bitToChange += 8;
            }
            Console.WriteLine(number);
        }
    }
}