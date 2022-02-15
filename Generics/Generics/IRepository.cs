using System;
using System.Collections.Generic;

namespace Generics
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
