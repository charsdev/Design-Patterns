using System.Collections.Generic;

namespace DAO
{
    public interface IDao<T>
    {
        List<T> GetAll();
        void Update(T entity);
        T Get(int id);
        void Delete(T entity);
        void Add(T entity);
    }
}
