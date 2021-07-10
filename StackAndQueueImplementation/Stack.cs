using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueImplementation
{
    class Stack
    {
        internal Node top;
        public Stack()
        {
            this.top = null;
        }

        //Pushing elements into stack
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
            }
        }

        //Display elements in a stack
        public void Display()
        {
            Node temp = top;
            if (top == null)
                Console.WriteLine("Stack is Empty");
            else
            {
                Console.Write(" " + temp.data);
                temp = temp.Next;
                while (temp != null)
                {
                    Console.Write(" -> " + temp.data);
                    temp = temp.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
