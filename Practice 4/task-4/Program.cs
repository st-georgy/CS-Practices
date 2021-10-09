using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary dict = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));

            dict["Krankenhaus"] = "Hospital";
            dict["США"] = "USA";
            dict["Canada"] = "Canada";

            Console.WriteLine(dict["США"]);
            Console.WriteLine(dict["Krankenhaus"]);
            Console.WriteLine(dict["Canada"]);

            Console.ReadKey();
        }
    }
}
