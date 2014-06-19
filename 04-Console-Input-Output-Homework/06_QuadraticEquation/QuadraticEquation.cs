// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0
// and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Calculation of the roots of quadratic equation by given a, b and c coefficients.");
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - (4 * a * c);
        double mathSqrtDiscriminant = Math.Sqrt(discriminant);
        
        if (discriminant < 0)
        {
            Console.WriteLine("The quadratic equation has no real roots");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine("The quadratic equation has one root: x = {0}", root);
        }
        else
        {
            double firstRoot = (-b - mathSqrtDiscriminant) / (2 * a);
            double secondRoot = (-b + mathSqrtDiscriminant) / (2 * a);
            Console.WriteLine("The quadratic equation has two roots: x1 = {0} and x2 = {1}", firstRoot, secondRoot);
        }
    }
}