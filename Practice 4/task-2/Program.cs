using System;
using System.Collections;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("Artyom");
            queue.Enqueue("Rusal84");
            queue.Enqueue("Ezhiki");
            queue.Enqueue("Ivan");
            queue.Enqueue(245);
            queue.Enqueue(24.3f);

            while(queue.Count > 0)
            {
                object obj = queue.Dequeue();
                Console.WriteLine($"From Queue: {obj}");
            }
            Console.WriteLine("\n\n");

            Stack stack = new Stack();
            stack.Push("Artyom");
            stack.Push("Rusal84");
            stack.Push("Ezhiki");
            stack.Push("Ivan");
            stack.Push(245);
            stack.Push(24.3f);

            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine($"From Stack: {obj}");
            }

            Console.ReadKey();
        }
    }
}
