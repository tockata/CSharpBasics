using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char asciiCharacter = '\u0000';
        for (int i = 0; i < 256; i++)
        {
            Console.Write("{0}. {1}; ", i, asciiCharacter);
            asciiCharacter++;
        }
        Console.WriteLine();
    }
}