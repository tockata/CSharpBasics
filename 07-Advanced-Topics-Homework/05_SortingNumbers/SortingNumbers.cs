// Write a program that reads a number n and a sequence of n integers, sorts them and prints them.

using System;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
		}

        Array.Sort(numbers);
        foreach (int number in numbers)
	    {
		    Console.WriteLine(number);
	    }
    }
}