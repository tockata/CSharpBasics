// Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
// If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. 
// Print the result at the console. Use switch statement.

using System;
using System.Threading;
using System.Globalization;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int integerNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(integerNumber + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string input = Console.ReadLine();
                Console.WriteLine(input + "" + "*");
                break;
            default: break;
        }
    }
}