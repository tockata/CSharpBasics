//Declare five variables choosing for each of them the most appropriate of the types
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
//52130, -115, 4825932, 97, -10000. 
//Choose a large enough type for each number to ensure it will fit in it. 
//Try to compile the code.

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort firstNumber = 52130;
        sbyte secondNumber = -115;
        int thirdNumber = 4825932;
        byte forthNumber = 97;
        short fifthNumber = -10000;

        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", firstNumber, secondNumber, thirdNumber, forthNumber, fifthNumber);
    }
}