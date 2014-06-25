using System;


class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());
        bool magicDateFound = false;

        DateTime start = new DateTime(startYear, 1, 1);
        DateTime end = new DateTime(endYear, 12, 31);

        for (DateTime d = start; d <= end; d = d.AddDays(1))
        {
            int d1 = d.Day / 10;
            int d2 = d.Day % 10;
            int d3 = d.Month / 10;
            int d4 = d.Month % 10;
            int d5 = d.Year / 1000;
            int d6 = (d.Year / 100) % 10;
            int d7 = (d.Year / 10) % 10;
            int d8 = d.Year % 10;
            int[] digits = { d1, d2, d3, d4, d5, d6, d7, d8 };
            int weight = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                for (int j = i + 1; j < digits.Length; j++)
                {
                    weight = weight + (digits[i] * digits[j]);
                }
            }
            if (weight == magicWeight)
            {
                Console.WriteLine("{0:d2}-{1:d2}-{2}", d.Day, d.Month, d.Year);
                magicDateFound = true;
            }
        }
        if (magicDateFound == false)
        {
            Console.WriteLine("No");
        }
    }
}