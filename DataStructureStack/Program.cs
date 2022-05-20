using System;
using System.Net.Http.Headers;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome To Stack and Queues");
            //Console.WriteLine("Stack Program");
            //Stacks stacks = new Stacks();
            //stacks.Push(70);
            //stacks.Push(30);
            //stacks.Push(56);
            //stacks.Display();

            //stacks.Peek();

            //stacks.Pop();

            //stacks.IsEmpty();

            Console.WriteLine("welcome to Queue");
            
            Queue queue = new Queue();
            
            queue.Enqueue(44);
            queue.Enqueue(33);
            queue.Enqueue(23);
            queue.DisplayQueue();

        }
    }
}