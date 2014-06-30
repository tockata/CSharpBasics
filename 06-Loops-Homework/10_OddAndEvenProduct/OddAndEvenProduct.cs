// You are given n integers (given in a single line, separated by a space). 
// Write a program that checks whether the product of the odd elements is equal to the product of the even elements. 
// Elements are counted from 1 to n, so the first element is odd, the second is even

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 1; i <= numbers.Length; i++)
        {
            if (i % 2 != 0)
            {
                oddProduct *= Convert.ToInt32(numbers[i - 1]);
            }
            else if (i % 2 == 0)
            {
                evenProduct *= Convert.ToInt32(numbers[i - 1]);
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}