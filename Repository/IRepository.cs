using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T value);
        void Update(T value);
        void Delete(int id);
        void Save();
    }
}
