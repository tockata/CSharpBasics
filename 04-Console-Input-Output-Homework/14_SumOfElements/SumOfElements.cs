using System;

class SumOfElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] stringNumbers = input.Split(' ');
        long[] numbers = new long[stringNumbers.Length];
        bool elementFound = false;
        long minDifference = long.MaxValue;
        long sum = 0;

        for (int i = 0; i < stringNumbers.Length; i++)
        {
            numbers[i] = Convert.ToInt64(stringNumbers[i]);
            sum += numbers[i];
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            long sumToCheck = sum - numbers[i];
            if (numbers[i] == sumToCheck)
            {
                Console.WriteLine("Yes, sum={0}", sumToCheck);
                elementFound = true;
                break;
            }
            else
            {
                long difference = Math.Abs(sumToCheck - numbers[i]);
                if (difference < minDifference)
                {
                    minDifference = difference;
                }
            }
        }
        if (elementFound == false)
        {
            Console.WriteLine("No, diff={0}", minDifference);
        }
    }
}