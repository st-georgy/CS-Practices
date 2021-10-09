using System;
using System.Collections.Generic;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> countryCode = new Dictionary<int, string>();

            countryCode[44] = "United Kingdom";
            countryCode[33] = "France";
            countryCode[31] = "Netherlands";
            countryCode[55] = "Brazil";
            countryCode[64] = "New Zealand";

            foreach (KeyValuePair<int, string> item in countryCode)
                Console.WriteLine($"Code {item.Key} is for {item.Value}");

            Console.ReadKey();
        }
    }
}
