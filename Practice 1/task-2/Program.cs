using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte a = 0;
            Byte b = 0;
            Int16 c = 0;
            Int32 d = 0;
            Int64 e = 0;
            string s = "";
            Exception ex = new Exception();

            object[] types = { a, b, c, d, e, s, ex};

            foreach (object obj in types)
            {
                string type;
                type = obj.GetType().IsValueType ? "Value Type" : "Reference Type";
                Console.WriteLine($"{obj.GetType()}: {type}");
            }

            Console.ReadKey();
        }
    }
}
