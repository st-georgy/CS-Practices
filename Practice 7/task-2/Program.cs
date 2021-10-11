using System;
using System.Threading;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex mutex = null;
            const string mutexName = "RUNMEONLYONCE";
            try
            {
                mutex = Mutex.OpenExisting(mutexName);
            } catch (WaitHandleCannotBeOpenedException)
            {}
            if (mutex == null)
                mutex = new Mutex(true, mutexName);
            else
            {
                mutex.Close();
                return;
            }
            Console.WriteLine("Mutex app");
            Console.ReadKey();
        }
    }
}
