using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            short i16 = 1;
            int i32 = 1;
            double db = 1;

            i16 = 132;
            //i16 = db;
            i32 = i16;
            //i32 = db;
            db = 116; db = i32;
        }
    }
}
