// Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.

using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        DateTime firstDate = DateTime.ParseExact(firstInput, "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(secondInput, "d.M.yyyy", CultureInfo.InvariantCulture);

        TimeSpan daysBetween = secondDate - firstDate;
        int days = daysBetween.Days;
        Console.WriteLine(days);
    }
}