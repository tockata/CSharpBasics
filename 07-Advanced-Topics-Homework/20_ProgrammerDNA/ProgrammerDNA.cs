using System;

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        string letters = "ABCDEFG";
        int startIndex = 0;

        switch (letter)
        {
            case 'A': startIndex = 0; break;
            case 'B': startIndex = 1; break;
            case 'C': startIndex = 2; break;
            case 'D': startIndex = 3; break;
            case 'E': startIndex = 4; break;
            case 'F': startIndex = 5; break;
            case 'G': startIndex = 6; break;
            default:
                break;
        }

        int count = 3;
        int lettersCount = 1;
        int row = 0;
        for (int i = 0; i < n; i++)
        {
            if (row <= 3)
            {
                string dots = new string('.', count);
                Console.Write("{0}", dots);
                for (int j = 0; j < lettersCount; j++)
                {
                    Console.Write(letters[startIndex]);
                    startIndex++;
                    if (startIndex > letters.Length - 1)
                    {
                        startIndex -= 7;
                    }
                }
                Console.WriteLine("{0}", dots);
                if (row < 3)
                {
                    count--;
                    lettersCount += 2;
                }
                if (row == 3)
                {
                    count++;
                    lettersCount -= 2;
                }
            }
            if (row > 3)
            {
                string dots = new string('.', count);
                Console.Write("{0}", dots);
                for (int j = 0; j < lettersCount; j++)
                {
                    Console.Write(letters[startIndex]);
                    startIndex++;
                    if (startIndex > letters.Length - 1)
                    {
                        startIndex -= 7;
                    }
                }
                Console.WriteLine("{0}", dots);
                count++;
                lettersCount -= 2;
            }
            row++;
            if (row == 7)
            {
                row = 0;
                count--;
                lettersCount += 2;
            }
        }
    }
}