// Write an if-statement that takes two doubleeger variables a and b and exchanges their values if the first one is greater than the second one. 
// As a result prdouble the values a and b, separated by a space.

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double tempNumber;

        if (firstNumber > secondNumber)
        {
            tempNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempNumber;
        }
        Console.WriteLine("{0} {1}", firstNumber, secondNumber);
    }
}