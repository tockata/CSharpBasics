// Write a program that reads a list of names and prints for each name how many times it appears in the list. 
// The names should be listed in alphabetical order. Use the input and output format from the examples below.

using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] namesArray = input.Split(' ');
        Dictionary<string, int> names = new Dictionary<string, int>();

        for (int i = 0; i < namesArray.Length; i++)
        {
            if (names.ContainsKey(namesArray[i]) == false)
            {
                names.Add(namesArray[i], 1);
            }
            else
            {
                names[namesArray[i]] += 1;
            }
        }
        
        List<string> keys = names.Keys.ToList();
        keys.Sort();

        foreach (string key in keys)
        {
            Console.WriteLine("{0} -> {1}", key, names[key]);
        }
    }
}