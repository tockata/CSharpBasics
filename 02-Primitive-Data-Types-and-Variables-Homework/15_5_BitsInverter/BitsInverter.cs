using System;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int bitToChange = 7;
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 7; j >= 0; j--)
            {
                if (bitToChange >= 0)
                {
                    int mask = 1 << bitToChange;
                    int maskAndNumber = mask & number;
                    int result = maskAndNumber >> bitToChange;
                    if (result == 0)
                    {
                        number = number | mask;
                    }
                    else if (result == 1)
                    {
                        number = number ^ mask;
                    }
                    bitToChange -= step;
                    if (bitToChange < 0)
                    {
                        bitToChange += 8;
                        break;
                    }
                }
                else
                {
                    bitToChange += 8;
                    break;
                }
            }
            numbers[i] = number;
        }
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}