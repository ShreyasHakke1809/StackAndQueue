using System.Collections.Generic;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stack And Queue Program");
            LinkedListStack list = new LinkedListStack();
            list.Push(56);
            list.Push(30);
            list.Push(70);
            list.Display();
        }
    }
}