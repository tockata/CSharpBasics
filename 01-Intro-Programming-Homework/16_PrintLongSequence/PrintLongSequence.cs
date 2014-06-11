// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 
// You might need to learn how to use loops in C# (search in Internet).

using System;

class PrintLongSequence
{
    static void Main()
    {
        int i = 2;
        while (i < 1002)
        {
            if (i % 2 == 0 && i != 1001)
            {
                Console.Write("{0}, ", i);
                i++;
            }
            else if (i % 2 != 0 && i != 1001)
            {
                Console.Write("-{0}, ", i);
                i++;
            }
            else
            {
                Console.WriteLine("-{0}", i);
                i++;
            }
        }
    }
}