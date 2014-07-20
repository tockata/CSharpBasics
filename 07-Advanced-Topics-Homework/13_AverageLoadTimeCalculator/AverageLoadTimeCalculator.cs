// We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below. 
// Your tasks is to calculate the average load time for each URL. Print the URLs in the same order as they first appear in the input report.
// Print the output in the format given below. Use double floating-point precision.

using System;
using System.Collections.Generic;
using System.Linq;

class AverageLoadTimeCalculator
{
    static void Main()
    {
        List<string> data = new List<string>();
        string input = Console.ReadLine();
        Dictionary<string, double> urls = new Dictionary<string, double>();
        Dictionary<string, int> countUrls = new Dictionary<string, int>();

        while (input != string.Empty)
        {
            data.Add(input);
            input = Console.ReadLine();
        }
        foreach (string urlData in data)
        {
            string[] split = urlData.Split(' ');
            if (urls.ContainsKey(split[2]) == false)
            {
                urls.Add(split[2], double.Parse(split[3]));
                countUrls.Add(split[2], 1);
            }
            else
            {
                urls[split[2]] += double.Parse(split[3]);
                countUrls[split[2]] += 1;
            }
        }
        
        foreach (string urlsName in urls.Keys)
        {
            double averageTime = urls[urlsName] / countUrls[urlsName];
            Console.WriteLine("{0} -> {1}", urlsName, averageTime);
        }
    }
}