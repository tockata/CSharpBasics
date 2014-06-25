// Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
// Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7" ||
            input == "8" || input == "9" || input == "10" || input == "J" || input == "Q" || input == "K" || input == "A")
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}