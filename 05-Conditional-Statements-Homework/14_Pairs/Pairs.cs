using System;

class Pairs
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int sum = Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]);
        int maxDiff = int.MinValue;
        int tempDiff = int.MinValue;
        int tempSum = 0;
        bool diffFound = false;

        for (int i = 2; i < numbers.Length - 1; i += 2)
        {
            tempSum = Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[i + 1]);
            if (tempSum != sum)
            {
                diffFound = true;
                tempDiff = Math.Abs(tempSum - sum);
                sum = tempSum;
                if (tempDiff > maxDiff)
                {
                    maxDiff = tempDiff;
                }
            }
        }
        if (diffFound == false)
        {
            Console.WriteLine("Yes, value={0}", sum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}