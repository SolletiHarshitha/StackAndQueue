using System;

namespace StackAndQueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------Stack------------------------\n");
            Stack stack = new Stack();

            //Push elements
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            while (!(stack.IsEmpty()))
            {
                //Display list
                stack.Display();
                //Peak element of stack
                stack.Peak();
                //Pop element
                stack.Pop();
                Console.WriteLine();
            }

            //Display stack
            stack.Display();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("-------------------------Queue-----------------------\n");
            Queue queue = new Queue();

            //Adding elements
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            Console.WriteLine(" Before Dequeue");
            queue.Display();
            queue.Dequeue();

            Console.WriteLine(" After Dequeue");
            queue.Display();
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
