using System;
using System.Collections.Generic;

class FiveSpecialLetters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        char[] letters = { 'a', 'b', 'c', 'd', 'e' };
        char[] result = new char[5];
        bool sequenceFound = false;

        for (int i = 0; i < letters.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                for (int k = 0; k < letters.Length; k++)
                {
                    for (int l = 0; l < letters.Length; l++)
                    {
                        for (int m = 0; m < letters.Length; m++)
                        {
                            result[0] = letters[i];
                            result[1] = letters[j];
                            result[2] = letters[k];
                            result[3] = letters[l];
                            result[4] = letters[m];

                            if (calculateWeight(result, start, end))
                            {
                                PrintResult(result);
                                sequenceFound = true;
                            }
                        }
                    }
                }
            }
        }
        if (sequenceFound == false)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine();
        }
    }

    private static bool calculateWeight(char[] result, int start, int end)
    {
        List<Char> chars = new List<Char>();
        int weight = 0;

        for (int i = 1; i <= result.Length; i++)
        {
            if (chars.Contains(result[i - 1]) == false)
            {
                chars.Add(result[i - 1]);
                switch (chars[chars.Count - 1])
                {
                    case 'a': weight += chars.Count * 5; break;
                    case 'b': weight += chars.Count * (-12); break;
                    case 'c': weight += chars.Count * 47; break;
                    case 'd': weight += chars.Count * 7; break;
                    case 'e': weight += chars.Count * (-32); break;
                    default: break;
                }
            }
        }
        if (weight >= start && weight <= end)
        {
            chars.Clear();
            weight = 0;
            return true;
        }
        else
        {
            chars.Clear();
            weight = 0;
            return false;
        }
    }

    private static void PrintResult(char[] result)
    {
        foreach (char character in result)
        {
            Console.Write(character);
        }
        Console.Write(" ");
    }
}