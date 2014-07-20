using System;
using System.Collections.Generic;

class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int totalLength = 0;
        int piecesCount = 0;
        int studentCables = 0;
        int remainder = 0;

        for (int i = 0; i < n; i++)
        {
            int cable = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();
            if (measure == "meters")
            {
                cable *= 100;
                if (cable > 19)
                {
                    totalLength += cable;
                    piecesCount++;
                }
            }
            else if (measure == "centimeters")
            {
                if (cable > 19)
                {
                    totalLength += cable;
                    piecesCount++;
                }
            }
        }
        totalLength = totalLength - ((piecesCount - 1) * 3);
        studentCables = totalLength / 504;
        remainder = totalLength % 504;
        Console.WriteLine(studentCables);
        Console.WriteLine(remainder);
    }
}