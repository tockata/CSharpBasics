// Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list,
// and all numbers from the second list, without repeating numbers, and arranged in increasing order. 
// The input and output lists are given as integers, separated by a space, each list at a separate line.

using System;
using System.Collections.Generic;

class JoinLists
{
    static void Main(string[] args)
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();
        string[] one = firstInput.Split(' ');
        string[] two = secondInput.Split(' ');
        int[] firstNumbers = new int[one.Length];
        int[] secondNumbers = new int[two.Length];
        List<int> result = new List<int>();

        for (int i = 0; i < firstNumbers.Length; i++)
        {
            firstNumbers[i] = int.Parse(one[i]);
        }
        for (int i = 0; i < secondNumbers.Length; i++)
        {
            secondNumbers[i] = int.Parse(two[i]);
        }
        foreach (int number in firstNumbers)
        {
            if (!result.Contains(number))
            {
                result.Add(number);
            }
        }
        foreach (int number in secondNumbers)
        {
            if (!result.Contains(number))
            {
                result.Add(number);
            }
        }
        result.Sort();
        foreach (int number in result)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }
}