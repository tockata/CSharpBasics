using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == n)
            {
                string frames = new string('*', (n * 2));
                string spaceBetweenFrames = new string(' ', n);
                Console.WriteLine("{0}{1}{0}", frames, spaceBetweenFrames);
            }
            else if (i == (n + 1) / 2)
            {
                string lens = new string('/', ((2 * n) - 2));
                string bridge = new string('|', n);
                Console.WriteLine("*{0}*{1}*{0}*", lens, bridge);
            }
            else
            {
                string lens = new string('/', ((2 * n) - 2));
                string spaceBetweenFrames = new string(' ', n);
                Console.WriteLine("*{0}*{1}*{0}*", lens, spaceBetweenFrames);
            }
        }
    }
}