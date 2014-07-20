// Write a program that takes as input two lists of names and removes from the first list all names given in the second list. 
// The input and output lists are given as words, separated by a space, each list at a separate line.

using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();
        string[] firstArray = firstInput.Split(' ');
        string[] secondArray = secondInput.Split(' ');
        List<string> firstList = new List<string>();

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstList.Add(firstArray[i]);
        }
        for (int i = 0; i < secondArray.Length; i++)
        {
            do
            {
                firstList.Remove(secondArray[i]);
            } while (firstList.Contains(secondArray[i]));
        }
        foreach (string name in firstList)
        {
            Console.Write("{0} ", name);
        }
        Console.WriteLine();
    }
}