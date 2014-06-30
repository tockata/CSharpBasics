using System;
using System.Globalization;

class ExamSchedule
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int examHours = int.Parse(Console.ReadLine());
        int examMinutes = int.Parse(Console.ReadLine());
        DateTime startTime = new DateTime();

        DateTime dateTimeNow = DateTime.Now;
        if (partOfDay == "AM")
        {
            startTime = new DateTime(2014, 06, 29, hours, minutes, 0);
        }
        else if (partOfDay == "PM")
        {
            startTime = new DateTime(2014, 06, 29, hours + 12, minutes, 0);
        }

        DateTime endTime = startTime.AddHours(examHours).AddMinutes(examMinutes);
        Console.WriteLine(endTime.ToString("hh:mm:tt", CultureInfo.CreateSpecificCulture("en-us")));
    }
}