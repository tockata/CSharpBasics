using System;
using System.Collections.Generic;

class BitKiller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        List<string> digits = new List<string>();
        int startBit = 6;
        string result = "";

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 7; j >= 0; j--)
            {
                if (j != startBit)
                {
                    int bit = (number & (1 << j)) >> j;
                    digits.Add(Convert.ToString(bit));
                }
                else
                {
                    startBit -= step;
                    
                }
                if (digits.Count == 8)
                {
                    foreach (string digit in digits)
                    {
                        result = result + "" + digit;
                    }
                    int numberToPrint = Convert.ToInt32(result, 2);
                    Console.WriteLine(numberToPrint);
                    digits.Clear();
                    result = "";
                }
            }
            if (startBit < 0)
            {
                startBit += 8;
            }
        }
        if (digits.Count != 8 && digits.Count != 0)
        {
            while(digits.Count != 8)
            {
                digits.Add("0");
            }
            foreach (string digit in digits)
            {
                result = result + "" + digit;
            }
            int numberToPrint = Convert.ToInt32(result, 2);
            Console.WriteLine(numberToPrint);
            digits.Clear();
        }
    }
}