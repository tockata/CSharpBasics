// Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns

using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] splittedInput = input.Split(' ');
        int rows = int.Parse(splittedInput[0]);
        int cols = int.Parse(splittedInput[1]);
        string letters = "abcdefghijklmnopqrstuvwxyz";
        int middleLetterIndex = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0}{1}{0} ", letters[i], letters[middleLetterIndex]);
                middleLetterIndex++;
            }
            Console.WriteLine();
            middleLetterIndex = i + 1;
        }
    }
}