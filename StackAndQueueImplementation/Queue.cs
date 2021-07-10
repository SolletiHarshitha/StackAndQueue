using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueImplementation
{
    class Queue
    {
        internal Node head;
        public Queue()
        {
            this.head = null;
        }

        //Enqueue elements
        public void Enqueue(int data)
        {
            // Adding At Last in the Queue....
            Node newNode = new Node(data);
            if (head == null)
                head = newNode;
            else
            {
                Node temp = head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = newNode;
            }
        }

        //Display elements
        public void Display()
        {
            // Displaying Queue....
            if (head == null)
                Console.WriteLine("Queue is Empty");
            else
            {
                Node temp = head;
                Console.Write("  ");
                while (temp != null)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.Next;
                }
                Console.Write("Null\n");
            }
        }
    }
}
