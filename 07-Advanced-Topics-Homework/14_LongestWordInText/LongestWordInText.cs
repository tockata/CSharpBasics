// Write a program to find the longest word in a text.

using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordInText
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] words = text.Split(' ', '.');
        Dictionary<string, int> wordsCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordsCount.ContainsKey(word) == false)
            {
                int count = word.Length;
                wordsCount.Add(word, count);
            }
        }
        string maxKey = wordsCount.ElementAt(0).Key;
        int maxValue = int.MinValue;
        foreach (string word in wordsCount.Keys)
        {
            if (wordsCount[word] > maxValue)
            {
                maxKey = word;
                maxValue = wordsCount[word];
            }
        }
        // second way:
        // string maxKey = wordsCount.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        Console.WriteLine(maxKey);
    }
}