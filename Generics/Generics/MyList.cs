using System;
using System.Collections.Generic;

namespace Generics
{
    public class MyList<T>
    {
        private List<T> newList = new List<T>();
        public void Add(T element)
        {
            newList.Add(element);
        }

        public T Remove(int index)
        {
            T value = newList[index];
            newList.RemoveAt(index);
            return value;
        }

        public bool Contains(T element)
        {

            int index = newList.IndexOf(element);
            if(index == -1)
            {
                return false;
            }
            return true;
        }

        public void Clear()
        {
            newList.Clear();
        }

        public void InsertAt(T element, int index)
        {
            newList.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            newList.RemoveAt(index);
        }

        public T Find(int index)
        {
            return newList[index];
        }
    }
}
