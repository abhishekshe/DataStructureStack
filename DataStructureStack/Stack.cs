using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace StacksAndQueues
{
    class Stacks
    {
        
        public Node top;
       
        public Stacks()
        {
            top = null;
        }
       
        public void Push(int data)
        {
            
            Node node = new Node(data);
            
            node.next = top;
            
            top = node;
            Console.WriteLine("Element Inserted In Stack:\t{0}", top.data);

        }
        
        public void Display()
        {
            Console.WriteLine("\nDisplaying the Stack");
            
            while (top != null)
            {
                Console.WriteLine(top.data);
                top = top.next;
            }
        }
    }
}