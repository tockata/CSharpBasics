// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInsideCircleAndOutsideOfRectangle
{
    static void Main()
    {
        double circleCenterX = 1;
        double circleCenterY = 1;
        double circleRadius = 1.5;

        Console.WriteLine("Enter point coordinates:");
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        double distanceFromCircleCenter = Math.Sqrt((x - circleCenterX) * (x - circleCenterX) + (y - circleCenterY) * ( y - circleCenterY));

        if (distanceFromCircleCenter <= circleRadius && y > 1)
        {
            Console.WriteLine("Yes! The point is inside the circle and outside the rectangle.");
        }
        else
        {
            Console.WriteLine("No! The point is not inside the circle and outside the rectangle.");
        }
    }
}