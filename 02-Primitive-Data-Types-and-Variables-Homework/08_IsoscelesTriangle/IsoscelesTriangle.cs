//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//    ©
//   © ©
//  ©   ©
// © © © ©

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyrightSign = '\u00A9';

        // First simple way:
        for (int i = 1; i <= 4; i++)
        {
            if (i == 1)
            {
                Console.WriteLine("   {0}   ", copyrightSign);
            }
            else if (i == 2)
            {
                Console.WriteLine("  {0} {0}  ", copyrightSign);
            }
            else if (i == 3)
            {
                Console.WriteLine(" {0}   {0} ", copyrightSign);
            }
            else if (i == 4)
            {
                Console.WriteLine("{0} {0} {0} {0}", copyrightSign);
            }

        }

        // Second way - draw isosceles triangle with given number of raws
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        int cols = rows + rows - 1;
        int lastrowColCount = 1;
        int outerCount = (cols - 3) / 2;
        int innerCount = 1;

        for (int i = 1; i < rows; i++)
        {
            if (i == 1)
            {
                Console.Write(new string(' ', (cols / 2)));
                Console.Write(copyrightSign);
                Console.WriteLine();
            }
            if (i == rows - 1)
            {
                while (lastrowColCount <= cols)
                {
                    Console.Write("{0} ", copyrightSign);
                    lastrowColCount += 2;
                }
            }
            else
            {
                Console.Write(new string(' ', outerCount));
                Console.Write(copyrightSign);
                Console.Write(new string(' ', innerCount));
                Console.Write(copyrightSign);
            }
            Console.WriteLine();
            outerCount--;
            innerCount += 2;
        }
    }
}