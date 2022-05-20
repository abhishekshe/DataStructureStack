using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class Queue
    {
        
        public Node head;
        
        public void Enqueue(int data)
        {
            
            Node node = new Node(data);
            Node temp = head;
            
            if (head == null)
            {
                head = node;
            }
            else
            {
              
                Node lastNode = GetLastNode(temp);
                lastNode.next = node;
            }
            Console.WriteLine("Element inserted in queue:\t{0}", node.data);

        }
        
        public Node GetLastNode(Node temp)
        {
            if (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
       
        public void DisplayQueue()
        {
            Console.WriteLine("\nDisplaying the Queue");
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("empty queue");
            }
            else
            {
                
                
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}