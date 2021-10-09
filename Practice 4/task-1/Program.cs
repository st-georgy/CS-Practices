using System;
using System.Collections;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Artyom");
            list.Add("Rusal84");
            list.Add("Ezhiki");
            list.Add("Ivan");

            foreach (string item in list)
                Console.WriteLine($"Unsorted: {item}");

            list.Sort();
            foreach (string item in list)
                Console.WriteLine($"Sorted: {item}");

            Console.ReadKey();
        }
    }
}
