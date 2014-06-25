using System;

class Triangle
{
    static void Main()
    {
        double aX = double.Parse(Console.ReadLine());
        double aY = double.Parse(Console.ReadLine());
        double bX = double.Parse(Console.ReadLine());
        double bY = double.Parse(Console.ReadLine());
        double cX = double.Parse(Console.ReadLine());
        double cY = double.Parse(Console.ReadLine());

        double distanceAB = Math.Sqrt(Math.Pow((aX - bX), 2) + Math.Pow((aY - bY), 2));
        double distanceAC = Math.Sqrt(Math.Pow((aX - cX), 2) + Math.Pow((aY - cY), 2));
        double distanceBC = Math.Sqrt(Math.Pow((bX - cX), 2) + Math.Pow((bY - cY), 2));

        double halfPerimter = (distanceAB + distanceAC + distanceBC) / 2;
        double area = Math.Sqrt(halfPerimter * (halfPerimter - distanceAB) * (halfPerimter - distanceAC) * (halfPerimter - distanceBC));

        if (distanceAB + distanceAC > distanceBC && distanceAB + distanceBC > distanceAC && distanceAC + distanceBC > distanceAB)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", distanceAB);
        }
    }
}