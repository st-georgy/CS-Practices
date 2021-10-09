using System;
using System.Collections;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            table["0"] = "Zero";
            table["1"] = "One";
            table["2"] = "Two";
            table["3"] = "Three";
            table["4"] = "Four";
            table["5"] = "Five";
            table["6"] = "Six";
            table["7"] = "Seven";
            table["8"] = "Eight";
            table["9"] = "Nine";

            string number = "7794-2323-5544";

            foreach (char c in number)
            {
                string digit = c.ToString();
                if (table.ContainsKey(digit))
                    Console.WriteLine(table[digit]);
            }

            Console.ReadKey();
        }
    }
}
