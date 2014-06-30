using System;

class OddEvenElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        decimal oddSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;
        decimal evenSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;
        decimal number;
        bool checkData = false;

        for (int i = 1; i <= inputArray.Length; i++)
        {
            checkData = decimal.TryParse(inputArray[i - 1], out number);
            if (i % 2 != 0)
            {
                oddSum += number;
                if (number < oddMin)
                {
                    oddMin = number;
                }
                if (number > oddMax)
                {
                    oddMax = number;
                }
            }
            if (i % 2 == 0)
            {
                evenSum += number;
                if (number < evenMin)
                {
                    evenMin = number;
                }
                if (number > evenMax)
                {
                    evenMax = number;
                }
            }
        }
        if (checkData == true && oddMin != decimal.MaxValue && oddMax != decimal.MinValue && evenMin != decimal.MaxValue &&
            evenMax != decimal.MinValue)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
            oddSum.ToString("G29"), oddMin.ToString("G29"), oddMax.ToString("G29"), evenSum.ToString("G29"), evenMin.ToString("G29"), evenMax.ToString("G29"));
        }
        else if (checkData == true && (oddMin == decimal.MaxValue || oddMax == decimal.MinValue))
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum={1}, EvenMin={2}, EvenMax={3}",
            evenSum.ToString("G29"), evenMin.ToString("G29"), evenMax.ToString("G29"));
        }
        else if (checkData == true && (evenMin == decimal.MaxValue || evenMax == decimal.MinValue))
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
            oddSum.ToString("G29"), oddMin.ToString("G29"), oddMax.ToString("G29"));
        }
        else
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
    }
}