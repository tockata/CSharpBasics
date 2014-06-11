using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool foundNumber = false;

        for (int i = 111; i <= 777; i++)
        {
            int abc = i;
            int def = abc + diff;
            int ghi = def + diff;
            int sumOfDigits = calcSumOfDigits(abc, def, ghi);

            if (sumOfDigits == sum)
            {
                string number = abc.ToString() + def.ToString() + ghi.ToString();
                Console.WriteLine(number);
                foundNumber = true;
            }
        }
        if (foundNumber == false)
        {
            Console.WriteLine("No");
        }
    }

    private static int calcSumOfDigits(int abc, int def, int ghi)
    {
        int firstAbcDigit = (abc / 100) % 10;
        int secondAbcDigit = (abc / 10) % 10;
        int thirdAbcDigit = abc % 10;
        int firstDefDigit = (def / 100) % 10;
        int secondDefDigit = (def / 10) % 10;
        int thirdDefDigit = def % 10;
        int firstGhiDigit = (ghi / 100) % 10;
        int secondGhiDigit = (ghi / 10) % 10;
        int thirdGhiDigit = ghi % 10;
        int sum = 0;

        if (firstAbcDigit != 0 && secondAbcDigit != 0 && thirdAbcDigit != 0 &&
            firstDefDigit != 0 && secondDefDigit != 0 && thirdDefDigit != 0 &&
            firstGhiDigit != 0 && secondGhiDigit != 0 && thirdGhiDigit != 0 &&
            firstAbcDigit != 8 && secondAbcDigit != 8 && thirdAbcDigit != 8 &&
            firstDefDigit != 8 && secondDefDigit != 8 && thirdDefDigit != 8 &&
            firstGhiDigit != 8 && secondGhiDigit != 8 && thirdGhiDigit != 8 &&
            firstAbcDigit != 9 && secondAbcDigit != 9 && thirdAbcDigit != 9 &&
            firstDefDigit != 9 && secondDefDigit != 9 && thirdDefDigit != 9 &&
            firstGhiDigit != 9 && secondGhiDigit != 9 && thirdGhiDigit != 9)
        {
            sum = firstAbcDigit + secondAbcDigit + thirdAbcDigit + firstDefDigit + secondDefDigit + thirdDefDigit +
                firstGhiDigit + secondGhiDigit + thirdGhiDigit;
            return sum;
        }
        else
        {
            return sum;
        }
    }
}