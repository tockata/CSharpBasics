// Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).

using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter point coordinates:");
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        bool inside;

        double distance = Math.Sqrt(x * x + y * y);
        if (distance <= 2)
        {
            inside = true;
            Console.WriteLine("Point with coordinates x = {0} and y = {1} is in the circle K((0,0), 2)? {2}", x, y, inside);
        }
        else
        {
            inside = false;
            Console.WriteLine("Point with coordinates x = {0} and y = {1} is in the circle K((0,0), 2)? {2}", x, y, inside);
        }

    }
}