// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        DateTime myBirthday = DateTime.Parse(Console.ReadLine());
        int age = 0;

        if (myBirthday.Date.Month <= DateTime.Now.Date.Month)
        {
            age = DateTime.Now.Year - myBirthday.Year;
        }
        else
        {
            age = DateTime.Now.Year - myBirthday.Year - 1;
        }

        Console.WriteLine("You are {0} years old.", age);
        Console.WriteLine("After 10 years you will be {0} years old.", (age + 10));
    }
}