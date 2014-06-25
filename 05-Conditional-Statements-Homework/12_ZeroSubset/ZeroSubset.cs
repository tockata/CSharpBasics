// We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. 
// Assume that repeating the same subset several times is not a problem.

using System;
using System.Collections.Generic;

class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers:");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());
        int fifthNumber = int.Parse(Console.ReadLine());
        bool subsetFound = false;

        if (firstNumber == 0)
        {
            Console.WriteLine("{0} = 0", firstNumber);
            subsetFound = true;
        }
        if (secondNumber == 0)
        {
            Console.WriteLine("{0} = 0", secondNumber);
            subsetFound = true;
        }
        if (firstNumber + secondNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNumber, secondNumber);
            subsetFound = true;
        }
        if (thirdNumber == 0)
        {
            Console.WriteLine("{0} = 0", thirdNumber);
            subsetFound = true;
        }
        if (firstNumber + thirdNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNumber, thirdNumber);
            subsetFound = true;
        }
        if (secondNumber + thirdNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNumber, thirdNumber);
            subsetFound = true;
        }
        if (firstNumber + secondNumber + thirdNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, thirdNumber);
            subsetFound = true;
        }
        if (fourthNumber == 0)
        {
            Console.WriteLine("{0} = 0", fourthNumber);
            subsetFound = true;
        }
        if (firstNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNumber, fourthNumber);
            subsetFound = true;
        }
        if (secondNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNumber, fourthNumber);
            subsetFound = true;
        }
        if (firstNumber + secondNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, fourthNumber);
            subsetFound = true;
        }
        if (thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdNumber, fourthNumber);
            subsetFound = true;
        }
        if (firstNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, thirdNumber, fourthNumber);
            subsetFound = true;
        }
        if (secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, thirdNumber, fourthNumber);
            subsetFound = true;
        }
        if (firstNumber + secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, thirdNumber, fourthNumber);
            subsetFound = true;
        }
        if (fifthNumber == 0)
        {
            Console.WriteLine("{0} = 0", fifthNumber);
            subsetFound = true;
        }
        if (firstNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNumber, fifthNumber);
            subsetFound = true;
        }
        if (secondNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNumber, fifthNumber);
            subsetFound = true;
        }
        if (firstNumber + secondNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, fifthNumber);
            subsetFound = true;
        }
        if (thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdNumber, fifthNumber);
            subsetFound = true;
        }
        if (firstNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, thirdNumber, fifthNumber);
            subsetFound = true;
        }
        if (secondNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, thirdNumber, fifthNumber);
            subsetFound = true;
        }
        if (firstNumber + secondNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3}= 0", firstNumber, secondNumber, thirdNumber, fifthNumber);
            subsetFound = true;
        }
        if (fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", fourthNumber, fifthNumber);
            subsetFound = true;
        }
        if (firstNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, fourthNumber, fifthNumber);
            subsetFound = true;
        }
        if (secondNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, fourthNumber, fifthNumber);
            subsetFound = true;
        }
        if (firstNumber + secondNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3}= 0", firstNumber, secondNumber, fourthNumber, fifthNumber);
            subsetFound = true;
        }
        if (thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", thirdNumber, fourthNumber, fifthNumber);
            subsetFound = true;
        }
        if (firstNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3}= 0", firstNumber, thirdNumber, fourthNumber, fifthNumber);
            subsetFound = true;
        }
        if (secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3}= 0", secondNumber, thirdNumber, fourthNumber, fifthNumber);
            subsetFound = true;
        }
        if (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4}= 0", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
            subsetFound = true;
        }
        if (subsetFound == false)
        {
            Console.WriteLine("no zero subset");
        }
    }
}