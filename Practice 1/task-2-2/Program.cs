using System;

namespace task_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Alexey Rusakov obozhaet studentov kormit vazelinom";
            string[] sa = s.Split(" ");

            Array.Sort(sa);

            s = string.Join(" ", sa);
            Console.WriteLine(s);
        }
    }
}
