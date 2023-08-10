using System.Collections;
using System.Collections.Generic;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stack And Queue Program");
            LinkedListStack list = new LinkedListStack();
            Queue queue = new Queue();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("\n1.Create a stack and push elements\n2.Peek and pop\n3.Enqueue elements ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                    case 1:
                    list.Push(56);
                    list.Push(30);
                    list.Push(70);
                    list.Display();
                    break;
                    case 2:
                    list.Push(56);
                    list.Push(30);
                    list.Push(70);
                    list.Display();
                    list.Peek();
                    list.Display();
                    list.Pop();
                    list.Display();
                    list.Peek();
                    list.Display();
                    list.Pop();
                    list.Display();
                    list.Peek();
                    list.Display();
                    list.Pop();
                    list.Display();
                    if (list.IsEmpty())
                    {
                        Console.WriteLine("\nThe stack is empty");
                    }
                    break;
                    case 3:
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Display();
                    break;
            }
        }
    }
}