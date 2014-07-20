// Write a program that calculates the perimeter and the area of given polygon (not necessarily convex) consisting of
// n floating-point coordinates in the 2D plane. Print the result rounded to two decimal digits after the decimal point. 
// Use the input and output format from the examples. To hold the points, define a class Point(x, y). 
// To hold the polygon use a Polygon class which holds a list of points. Find in Internet how to calculate the polygon perimeter
// and how to calculate the area of a polygon.

using System;
using System.Collections.Generic;
using System.Linq;

class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}

class Polygon
{
    public List<Point> PolygonPoints { get; set; }
}

class PerimeterAndAreaOfPolygon
{
    static void Main()
    {
        int numberOfPoints = int.Parse(Console.ReadLine());
        List<Point> listOfPoints = new List<Point>();
        double perimeter = 0;
        double area = 0;
        double dividend = 0;

        for (int i = 0; i < numberOfPoints; i++)
        {
            string input = Console.ReadLine();
            string[] splittedInput = input.Split(' ');
            Point point = new Point() { X = double.Parse(splittedInput[0]), Y = double.Parse(splittedInput[1]) };
            listOfPoints.Add(point);
        }
        Polygon myPolygon = new Polygon() { PolygonPoints =  listOfPoints };

        perimeter = CalculatePerimeter(myPolygon.PolygonPoints, perimeter);
        Console.WriteLine("{0:f2}", perimeter);

        area = CalculateArea(myPolygon.PolygonPoints, area, dividend);
        Console.WriteLine("{0:f2}", area);
    }

    private static double CalculatePerimeter(List<Point> points, double perimeter)
    {
        for (int i = 0; i < points.Count - 1; i++)
        {
            double distance = Math.Sqrt(Math.Pow((points[i].X - points[i + 1].X), 2) +
                Math.Pow((points[i].Y - points[i + 1].Y), 2));
            perimeter += distance;
            if (i == points.Count - 2)
            {
                distance = Math.Sqrt(Math.Pow((points[0].X - points[i + 1].X), 2) +
                Math.Pow((points[0].Y - points[i + 1].Y), 2));
                perimeter += distance;
            }
        }
        return perimeter;
    }

    private static double CalculateArea(List<Point> points, double area, double dividend)
    {
        for (int i = 0; i < points.Count; i++)
        {
            if (i < points.Count - 1)
            {
                double product = (points[i].X * points[i + 1].Y) - (points[i].Y * points[i + 1].X);
                dividend += product;
            }
            else
            {
                double product = (points[i].X * points[0].Y) - (points[i].Y * points[0].X);
                dividend += product;
            }
        }
        area = Math.Abs(dividend / 2);
        return area;
    }
}