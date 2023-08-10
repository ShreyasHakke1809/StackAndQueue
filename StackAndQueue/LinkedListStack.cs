using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class LinkedListStack
    {
        public Node top;

        public LinkedListStack()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);

            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("inserted value is {0}", data);
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("\n{0} is top element of the stack", this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("\n{0} is deleted from top of the stack", this.top.data);
            this.top = this.top.next;
        }
        public bool IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            return true;
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
