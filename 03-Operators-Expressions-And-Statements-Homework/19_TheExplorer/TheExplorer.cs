using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int insideCount = 1;
        int outsideCount = n / 2 - 1;

        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == n)
            {
                string outside = new string('-', n / 2);
                Console.WriteLine("{0}*{0}", outside);
            }
            else if (i <= n / 2 )
            {
                string outside = new string('-', outsideCount);
                string inside = new string('-', insideCount);
                Console.WriteLine("{0}*{1}*{0}", outside, inside);
                outsideCount--;
                insideCount += 2;
            }
            else if (i == n / 2 + 1)
            {
                string inside = new string('-', n - 2);
                Console.WriteLine("*{0}*", inside);
                outsideCount++;
                insideCount -= 2;
            }
            else if (i > n / 2 + 1 && i < n )
            {
                string outside = new string('-', outsideCount);
                string inside = new string('-', insideCount);
                Console.WriteLine("{0}*{1}*{0}", outside, inside);
                outsideCount++;
                insideCount -= 2;
            }
        }
    }
}