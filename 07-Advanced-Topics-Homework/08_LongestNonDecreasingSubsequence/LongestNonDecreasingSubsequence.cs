// Write a program that reads a sequence of integers and finds in it the longest non-decreasing subsequence. 
// In other words, you should remove a minimal number of numbers from the starting sequence, so that the resulting sequence is non-decreasing.
// In case of several longest non-decreasing sequences, print the leftmost of them. The input and output should consist of a single line, 
// holding integer numbers separated by a space.

// *************** THIS PROBLEM IS NOT SOLVED YET, SO DONT LOOK AT THE CODE ***************

using System;
using System.Collections.Generic;

class MatrixOfPalindromes
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbersInString= input.Split(' ');
        int[] numbers = new int[numbersInString.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numbersInString[i]);
        }

        List<List<int>> sequences = new List<List<int>>();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            List<int> subsequence = new List<int>();
            int firstNumber = numbers[i];
            subsequence.Add(firstNumber);
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (firstNumber <= numbers[j])
                {
                    subsequence.Add(numbers[j]);
                    firstNumber = numbers[j];
                }
            }
            sequences.Add(subsequence);
        }

        int maxCountIndex = 0;
        int count = 0;
        for (int i = 0; i < sequences.Count; i++)
        {
            if (sequences[i].Count > count)
            {
                count = sequences[i].Count;
                maxCountIndex = i;
            }
        }
        foreach (int number in sequences[maxCountIndex])
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 