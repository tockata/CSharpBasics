using System;

class WorkHours
{
    static void Main()
    {
        decimal h = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal realWorkHours = Math.Truncate(((90m / 100) * d) * (12 * (p / 100)));
        
        if (realWorkHours >= h)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(realWorkHours - h);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine(realWorkHours - h);
        }
    }
}