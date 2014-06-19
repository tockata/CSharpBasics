using System;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] symbols = { 'k', 'n', 'p', 's' };
        char[] firstSequence = new char[4];
        char[] secondSequence = new char[4];
        bool foundSequence = false;
        
        for (int i = 0; i < symbols.Length; i++)
        {
            for (int j = 0; j < symbols.Length; j++)
            {
                for (int k = 0; k < symbols.Length; k++)
                {
                    for (int l = 0; l < symbols.Length; l++)
                    {
                        firstSequence[0] = symbols[i];
                        firstSequence[1] = symbols[j];
                        firstSequence[2] = symbols[k];
                        firstSequence[3] = symbols[l];

                        for (int m = 0; m < symbols.Length; m++)
                        {
                            for (int n = 0; n < symbols.Length; n++)
                            {
                                for (int o = 0; o < symbols.Length; o++)
                                {
                                    for (int p = 0; p < symbols.Length; p++)
                                    {
                                        secondSequence[0] = symbols[m];
                                        secondSequence[1] = symbols[n];
                                        secondSequence[2] = symbols[o];
                                        secondSequence[3] = symbols[p];

                                        int firstSum = 0;
                                        int secondSum = 0;
                                        foreach (char character in firstSequence)
	                                    {
		                                    switch (character)
                                            {
                                                case 'k': firstSum += 1; break;
                                                case 'n': firstSum += 4; break;
                                                case 'p': firstSum += 5; break;
                                                case 's': firstSum += 3; break;
                                                default: break;
                                            }
	                                    }
                                        foreach (char character in secondSequence)
                                        {
                                            switch (character)
                                            {
                                                case 'k': secondSum += 1; break;
                                                case 'n': secondSum += 4; break;
                                                case 'p': secondSum += 5; break;
                                                case 's': secondSum += 3; break;
                                                default: break;
                                            }
                                        }
                                        if (Math.Abs(firstSum - secondSum) == diff)
                                        {
                                            foreach (char character in firstSequence)
                                            {
                                                Console.Write(character);
                                            }
                                            foreach (char character in secondSequence)
                                            {
                                                Console.Write(character);
                                            }
                                            Console.WriteLine();
                                            foundSequence = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (foundSequence == false)
        {
            Console.WriteLine("No");
        }
    }
}