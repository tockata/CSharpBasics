using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string year = Console.ReadLine();
        double p = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double count = 0;

        if (year == "f")
        {
            count = (0.5 * p) + (((52 - h) * 2) / 3) + h;
        }
        else if (year == "t")
        {
            count = (0.5 * p) + (((52 - h) * 2) / 3) + h + 3;
        }

        Console.WriteLine(Math.Truncate(count));
    }
}
