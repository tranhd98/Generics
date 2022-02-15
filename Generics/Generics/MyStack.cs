using System;
using System.Collections.Generic;

namespace Generics
{
    public class MyStack<T>
    {
        private List<T> stack = new List<T>();
        public int Count()
        {
            return stack.Count;
        }
        public T Pop()
        {
            
            if(Count() == 0)
            {
                return default(T);
            }
            T value = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return value;
        }
        public void Push(T value)
        {
            stack.Add(value);
        }
    }
}
