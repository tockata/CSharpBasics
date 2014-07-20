// Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), 
// then find and print the longest sequence of equal elements (first its length, then its elements). 
// If multiple sequences have the same maximal length, print the leftmost of them.

using System;

class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] stringArray = new string[n];

        for (int i = 0; i < n; i++)
        {
            stringArray[i] = Console.ReadLine();
        }

        int maxCount = int.MinValue;
        int count = 1;
        int endIndex = 0;

        for (int i = 0; i < stringArray.Length - 1; i++)
        {
            if (stringArray[i] == stringArray[i + 1])
            {
                count++;
                if (i == stringArray.Length - 2)
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        endIndex = stringArray.Length - 1;
                    }
                }
            }
            else
            {
                if (count > maxCount)
                {
                    maxCount = count;
                    endIndex = i;
                }
                count = 1;
            }
        }
        Console.WriteLine(maxCount);
        int startIndex = endIndex - maxCount + 1;
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.WriteLine(stringArray[i]);
        }
    }
}