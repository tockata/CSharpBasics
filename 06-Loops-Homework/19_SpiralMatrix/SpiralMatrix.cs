// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n
// in the form of square spiral like in the examples below.
// n        matrix      n       matrix      n       matrix
// 2        1 2         3       1 2 3       4       1   2  3  4
//          4 3                 8 9 4               12 13 14  5
//                              7 6 5               11 16 15  6
//                                                  10  9  8  7

using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        bool[,] checkPosition = new bool[n, n];

        int col = 0;
        int row = 0;

        int right = 0;
        int down = 1;
        int left = 2;
        int up = 3;
        int direction = right;

        for (int i = 1; i <= matrix.Length; i++)
        {
            if (direction == right)
            {
                if (col < matrix.GetLength(0) && checkPosition[row, col] != true)
                {
                    matrix[row, col] = i;
                    checkPosition[row, col] = true;
                    col++;
                }
                else
                {
                    direction = down;
                    row++;
                    col--;
                }
            }
            if (direction == down)
            {
                if (row < matrix.GetLength(1) && checkPosition[row, col] != true)
                {
                    matrix[row, col] = i;
                    checkPosition[row, col] = true;
                    row++;
                }
                else
                {
                    direction = left;
                    col--;
                    row--;
                }
            }
            if (direction == left)
            {
                if (col >= 0 && checkPosition[row, col] != true)
                {
                    matrix[row, col] = i;
                    checkPosition[row, col] = true;
                    col--;
                }
                else
                {
                    direction = up;
                    row--;
                    col++;
                }
            }
            if (direction == up)
            {
                if (row >= 0 && checkPosition[row, col] != true)
                {
                    matrix[row, col] = i;
                    checkPosition[row, col] = true;
                    row--;
                    if (checkPosition[row, col] == true)
                    {
                        direction = right;
                        col++;
                        row++;
                    }
                }
                else
                {
                    direction = right;
                    col++;
                    row++;
                }
            }
        }
        PrintMatrix(matrix);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 10)
                {
                    Console.Write(matrix[i, j] + "   ");
                }
                else if (matrix[i, j] >= 10 && matrix[i, j] < 100)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                else
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}