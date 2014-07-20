// Write a program that reads a list of letters and prints for each letter how many times it appears in the list. 
// The letters should be listed in alphabetical order. Use the input and output format from the examples below.

using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] letters = input.Split(' ');
        Dictionary<string, int> letterCount = new Dictionary<string, int>();

        for (int i = 0; i < letters.Length; i++)
        {
            if (letterCount.ContainsKey(letters[i]) == false)
            {
                letterCount.Add(letters[i], 1);
            }
            else
            {
                letterCount[letters[i]] += 1;
            }
        }

        List<string> keys = letterCount.Keys.ToList();
        keys.Sort();

        foreach (string letter in keys)
        {
            Console.WriteLine("{0} -> {1}", letter, letterCount[letter]);
        }
    }
}