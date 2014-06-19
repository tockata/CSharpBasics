using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int asterixCount = 1;
        int dashCount = (n - 1) / 2;
        
        while(asterixCount<= n)
        {
            string roof = new string('*', asterixCount);
            string outsideRoof = new string('-', dashCount);
            Console.WriteLine("{0}{1}{0}", outsideRoof, roof);
            asterixCount += 2;
            dashCount--;
        }
        for (int i = 0; i < n; i++)
        {
            string house = new string('*', n - 2);
            Console.WriteLine("|{0}|", house);
        }
    }
}