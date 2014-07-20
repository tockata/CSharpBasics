// Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
// http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
// www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].StartsWith("http") || words[i].StartsWith("www"))
            {
                if (words[i].EndsWith("."))
                {
                    for (int j = 0; j < words[i].Length - 1; j++)
                    {
                        Console.Write(words[i][j]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}