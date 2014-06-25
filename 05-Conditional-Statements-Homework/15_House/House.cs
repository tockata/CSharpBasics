using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = (n - 2) / 2;
        int innerDots = 1;

        for (int i = 0; i <= n; i++)
        {
            if (i == 0)
            {
                string dots = new string('.', (n - 1) / 2);
                Console.WriteLine("{0}*{0}", dots);
            }
            else if (i == (n + 1) / 2)
            {
                string asterix = new string('*', n);
                Console.WriteLine(asterix);
            }
            else if (i >= 1 && i < (n / 2))
            {
                string outHouse = new string('.', outerDots);
                string inHouse = new string('.', innerDots);
                Console.WriteLine("{0}*{1}*{0}", outHouse, inHouse);
                outerDots--;
                innerDots += 2;
            }
            else if (i > (n / 2) && i < n)
            {
                string outHouse = new string('.', (n / 4));
                string inHouse = new string('.', (n - ((n / 4)*2 + 2)));
                Console.WriteLine("{0}*{1}*{0}", outHouse, inHouse);
            }
            else if (i == n)
            {
                string outHouse = new string('.', (n / 4));
                string baseOfHouse = new string('*', (n - ((n / 4) * 2)) -2);
                Console.WriteLine("{0}*{1}*{0}", outHouse, baseOfHouse);
            }
        }
    }
}