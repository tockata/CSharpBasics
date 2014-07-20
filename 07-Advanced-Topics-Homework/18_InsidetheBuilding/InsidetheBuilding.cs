using System;

class InsideTheBuilding
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());

        for (int i = 0; i < 5; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if ((x >= 0 && x <= h * 3) && (y >= 0 && y <= h)
            || (x >= h && x <= h * 2) && (y >= h && y <= h * 4))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}