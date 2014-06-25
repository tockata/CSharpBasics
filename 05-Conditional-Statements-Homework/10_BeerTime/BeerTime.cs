// A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt”
// (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or
// “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. 
// Note that you may need to learn how to parse dates and times.

using System;
using System.Threading;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter time \"hh:mm tt\": ");
        string input = Console.ReadLine();
        DateTime dt = new DateTime();
        bool checkFormat = DateTime.TryParseExact(input, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");

        if (checkFormat)
        {
            if (dt >= startTime || dt < endTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}