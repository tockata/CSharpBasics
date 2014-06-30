using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = 1;
        int innerDots = (((2 * n) - 1) - 4);

        for (int i = 1; i <= (2 * n) - 1; i++)
        {
            if (i == 1)
            {
                string arrowBase = new string('#', n);
                string outside = new string('.', (((n * 2 - 1) - n) / 2));
                Console.WriteLine("{0}{1}{0}", outside, arrowBase);
            }
            else if (i >= 2 && i <= n - 1)
            {
                string outside = new string('.', (((n * 2 - 1) - n) / 2));
                string inside = new string('.', n - 2);
                Console.WriteLine("{0}#{1}#{0}", outside, inside);
            }
            else if (i == n)
            {
                string outside = new string('#', (((2 * n) - 1) - (n - 2))/2);
                string inside = new string('.', n - 2);
                Console.WriteLine("{0}{1}{0}", outside, inside);
            }
            else if (i > n && i < (2 * n) - 1)
            {
                string outside = new string('.', outerDots);
                string inside = new string('.', innerDots);
                Console.WriteLine("{0}#{1}#{0}", outside, inside);
                outerDots++;
                innerDots -= 2;
            }
            else if (i == (2 * n) - 1)
            {
                string outside = new string('.', n - 1);
                Console.WriteLine("{0}#{0}", outside);
            }
        }
    }
}