using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> newList = new MyStack<int>();
            newList.Push(3);
            newList.Push(4);
            newList.Push(6);
            Console.WriteLine(newList.Count());
            Console.WriteLine(newList.Pop());
            Console.WriteLine(newList.Count());
            Console.WriteLine(newList.Pop());
            Console.WriteLine(newList.Count());
        }
    }
}
