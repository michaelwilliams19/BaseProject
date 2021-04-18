using System.Collections.Generic;

namespace fw.Interfaces
{
    public interface IABM<T> where T : IBaseEntity
    {
        void Save(T entity);
        void Delete(T entity);
        void Update(T entity);
        IList<T> ListAll();
    }
}