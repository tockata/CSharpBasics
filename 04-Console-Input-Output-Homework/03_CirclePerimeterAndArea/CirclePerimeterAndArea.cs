// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter circle radius: ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;

        // first way
        Console.WriteLine("Circle perimeter = {0:0.00}", perimeter);
        Console.WriteLine("Circle area = {0:0.00}", area);
        
        // second way
        Console.WriteLine("Circle perimeter = {0:F2}", perimeter);
        Console.WriteLine("Circle area = {0:F2}", area);
    }
}