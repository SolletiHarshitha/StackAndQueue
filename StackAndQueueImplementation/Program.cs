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
           

            //Display list
            stack.Display();


        }
    }
}
