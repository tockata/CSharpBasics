//Which of the following values can be assigned to a variable of type float and which to a variable of type double:
//34.567839023, 12.345, 8923.1234857, 3456.091? 
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {
        double firstNumber = 34.567839023;
        float secondNumber = 12.345f;
        double thirdNumber = 8923.1234857;
        float forthNumber = 3456.091f;

        Console.WriteLine("{0}, {1}, {2}, {3}", firstNumber, secondNumber, thirdNumber, forthNumber);
    }
}