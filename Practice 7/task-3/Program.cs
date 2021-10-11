using System;
using System.Threading;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitCallback callback = new WaitCallback(ShowText);
            ThreadPool.QueueUserWorkItem(callback, "Hello");
            ThreadPool.QueueUserWorkItem(callback, "Hi");
            ThreadPool.QueueUserWorkItem(callback, "Hallo");
            ThreadPool.QueueUserWorkItem(callback, "Privet");

            Console.ReadKey();
        }

        static void ShowText(object state)
        {
            string text = (string)state;
            Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId} - {text}");
        }
    }
}
