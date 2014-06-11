using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        double p = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double playTime = (2 / 3d) * p + h + (3 / 4d) * (48 - h);
        if (year == "leap")
        {
            playTime *= 1.15;
        }
        Console.WriteLine((int)playTime);
    }
}