// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Enter number between 0 and 999: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number >= 0 && number <= 9)
        {
            switch (number)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                default: break;
            }
        }
        else if (number >= 10 && number <= 19)
        {
            switch (number)
            {
                case 10: Console.WriteLine("Ten"); break;
                case 11: Console.WriteLine("Eleven"); break;
                case 12: Console.WriteLine("Twelve"); break;
                case 13: Console.WriteLine("Thirteen"); break;
                case 14: Console.WriteLine("Fourteen"); break;
                case 15: Console.WriteLine("Fifteen"); break;
                case 16: Console.WriteLine("Sixteen"); break;
                case 17: Console.WriteLine("Seventeen"); break;
                case 18: Console.WriteLine("Eighteen"); break;
                case 19: Console.WriteLine("Nineteen"); break;
                default: break;
            }
        }
        else if (number == 10 || number == 20 || number == 30 || number == 40 || number == 50 ||
                number == 60 || number == 70 || number == 80 || number == 90)
        {
            switch (number)
            {
                case 10: Console.WriteLine("Ten"); break;
                case 20: Console.WriteLine("Twenty"); break;
                case 30: Console.WriteLine("Thirty"); break;
                case 40: Console.WriteLine("Fourty"); break;
                case 50: Console.WriteLine("Fifty"); break;
                case 60: Console.WriteLine("Sixty"); break;
                case 70: Console.WriteLine("Seventy"); break;
                case 80: Console.WriteLine("Eighty"); break;
                case 90: Console.WriteLine("Ninety"); break;
                default: break;
            }
        }
        else if (number >= 21 && number <= 99)
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10;
            switch (firstDigit)
            {
                case 2: Console.Write("Twenty "); break;
                case 3: Console.Write("Thirty "); break;
                case 4: Console.Write("Fourty "); break;
                case 5: Console.Write("Fifty "); break;
                case 6: Console.Write("Sixty "); break;
                case 7: Console.Write("Seventy "); break;
                case 8: Console.Write("Eighty "); break;
                case 9: Console.Write("Ninety "); break;
                default: break;
            }
            switch (secondDigit)
            {
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default: break;
            }
        }
        else if (number >= 100)
        {
            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = (number % 100) % 10;
            int secondAndThirdDigits = number % 100;

            switch (firstDigit)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
                default: break;
            }
            if (secondDigit == 0 && thirdDigit == 0)
            {
                Console.WriteLine();
            }
            if (secondAndThirdDigits == 10 || secondAndThirdDigits == 11 || secondAndThirdDigits == 12 || secondAndThirdDigits == 13 || secondAndThirdDigits == 14
                || secondAndThirdDigits == 15 || secondAndThirdDigits == 16 || secondAndThirdDigits == 17 || secondAndThirdDigits == 18 || secondAndThirdDigits == 19
                || secondAndThirdDigits == 20 || secondAndThirdDigits == 30 || secondAndThirdDigits == 40 || secondAndThirdDigits == 50 || secondAndThirdDigits == 60
                || secondAndThirdDigits == 70 || secondAndThirdDigits == 80 || secondAndThirdDigits == 90)
            {
                switch (secondAndThirdDigits)
                {
                    case 10: Console.Write("and ten"); break;
                    case 20: Console.Write("and twenty "); break;
                    case 30: Console.Write("and thirty "); break;
                    case 40: Console.Write("and fourty "); break;
                    case 50: Console.Write("and fifty "); break;
                    case 60: Console.Write("and sixty "); break;
                    case 70: Console.Write("and seventy "); break;
                    case 80: Console.Write("and eighty "); break;
                    case 90: Console.Write("and ninety "); break;
                    case 11: Console.Write("and eleven "); break;
                    case 12: Console.Write("and twelve "); break;
                    case 13: Console.Write("and thirteen "); break;
                    case 14: Console.Write("and fourteen "); break;
                    case 15: Console.Write("and fifteen "); break;
                    case 16: Console.Write("and sixteen "); break;
                    case 17: Console.Write("and seventeen "); break;
                    case 18: Console.Write("and eighteen "); break;
                    case 19: Console.Write("and nineteen "); break;
                    default: break;
                }
                if (thirdDigit == 0 || secondAndThirdDigits == 10 || secondAndThirdDigits == 11 || secondAndThirdDigits == 12 || secondAndThirdDigits == 13 || secondAndThirdDigits == 14
                    || secondAndThirdDigits == 15 || secondAndThirdDigits == 16 || secondAndThirdDigits == 17 || secondAndThirdDigits == 18 || secondAndThirdDigits == 19)
                {
                    Console.WriteLine();
                }
            }
            else
            {
                switch (secondDigit)
                {
                    case 2: Console.Write("and twenty "); break;
                    case 3: Console.Write("and thirty "); break;
                    case 4: Console.Write("and fourty "); break;
                    case 5: Console.Write("and fifty "); break;
                    case 6: Console.Write("and sixty "); break;
                    case 7: Console.Write("and seventy "); break;
                    case 8: Console.Write("and eighty "); break;
                    case 9: Console.Write("and ninety "); break;
                    default: break;
                }
                if (secondDigit == 0 && thirdDigit != 0)
                {
                    Console.Write("and ");
                }
                switch (thirdDigit)
                {
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                    default: break;
                }
            }
        }
    }
}