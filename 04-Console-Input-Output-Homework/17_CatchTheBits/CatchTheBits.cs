using System;
using System.Collections.Generic;

class CatchTheBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        List<string> digits = new List<string>();
        int bitToExtract = 6;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 7; j >= 0; j--)
            {
                if (j == bitToExtract)
                {
                    int bit = (number & (1 << j)) >> j;
                    digits.Add(Convert.ToString(bit));
                    bitToExtract -= step;
                    if (digits.Count == 8)
                    {
                        PrintResult(digits);
                    }
                }
                if (bitToExtract < 0)
                {
                    bitToExtract += 8;
                    break;
                }
            }
        }
        if (digits.Count > 0 && digits.Count < 8)
        {
            while (digits.Count < 8)
            {
                digits.Add(Convert.ToString(0));
            }
            PrintResult(digits);
        }
    }

    private static void PrintResult(List<string> digits)
    {
        string result = string.Join("", digits);
        int output = Convert.ToInt32(result, 2);
        Console.WriteLine(output);
        digits.Clear();
    }
}