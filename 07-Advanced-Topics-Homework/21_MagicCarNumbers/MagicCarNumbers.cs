using System;

class MagicCarNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[] letters = new char[] { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] carNumber = new char[6];
        int count = 0;

        for (int i = 0; i < 10; i++)
        {
            carNumber[0] = numbers[i];
            for (int j = 0; j < 10; j++)
            {
                carNumber[1] = numbers[j];
                for (int k = 0; k < 10; k++)
                {
                    carNumber[2] = numbers[k];
                    for (int m = 0; m < 10; m++)
                    {
                        carNumber[3] = numbers[m];
                        for (int p = 0; p < 10; p++)
                        {
                            carNumber[4] = letters[p];
                            for (int q = 0; q < 10; q++)
                            {
                                carNumber[5] = letters[q];
                                if (checkMagicNumber(carNumber, n))
                                {
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }

    private static bool checkMagicNumber(char[] carNumber, int n)
    {
        int weight = 40;
        bool magicNumberFound = false;
        if ((carNumber[0] == carNumber[1] && carNumber[0] == carNumber[2] && carNumber[0] == carNumber[3])
            || (carNumber[1] == carNumber[2] && carNumber[1] == carNumber[3] && carNumber[0] != carNumber[1])
            || (carNumber[0] == carNumber[1] && carNumber[0] == carNumber[2] && carNumber[0] != carNumber[3])
            || (carNumber[0] == carNumber[1] && carNumber[2] == carNumber[3] && carNumber[0] != carNumber[2])
            || (carNumber[0] == carNumber[2] && carNumber[1] == carNumber[3] && carNumber[0] != carNumber[1])
            || (carNumber[0] == carNumber[3] && carNumber[1] == carNumber[2] && carNumber[0] != carNumber[1]))
        {
            for (int i = 0; i < carNumber.Length; i++)
            {
                switch (carNumber[i])
                {
                    case '1': weight += 1; break;
                    case '2': weight += 2; break;
                    case '3': weight += 3; break;
                    case '4': weight += 4; break;
                    case '5': weight += 5; break;
                    case '6': weight += 6; break;
                    case '7': weight += 7; break;
                    case '8': weight += 8; break;
                    case '9': weight += 9; break;
                    case '0': weight += 0; break;
                    case 'A': weight += 10; break;
                    case 'B': weight += 20; break;
                    case 'C': weight += 30; break;
                    case 'E': weight += 50; break;
                    case 'H': weight += 80; break;
                    case 'K': weight += 110; break;
                    case 'M': weight += 130; break;
                    case 'P': weight += 160; break;
                    case 'T': weight += 200; break;
                    case 'X': weight += 240; break;
                    default: break;
                }
            }
            if (weight == n)
            {
                magicNumberFound = true;
            }
        }
        return magicNumberFound;
    }
}