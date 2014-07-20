// Write a program that counts how many times a given word occurs in given text. The first line in the input holds the word.
// The second line of the input holds the text. The output should be a single integer number – the number of word occurrences.
// Matching should be case-insensitive. Note that not all matching substrings are words and should be counted. 
// A word is a sequence of letters separated by punctuation or start / end of text.

using System;
using System.IO;


class CountingWordInText
{
    static void Main()
    {
        Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

        string wordToCount = Console.ReadLine();
        string text = Console.ReadLine();
        string[] words = text.Split(' ', '.', ',', '"', ':', '/', '!', '?', '@', '(', ')');
        int count = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].ToLower() == wordToCount.ToLower())
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}