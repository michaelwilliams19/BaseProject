using System.Collections.Generic;
using fw.Interfaces;

namespace fw.Repositories
{
    public abstract class Repository<T> : IABM<T> where T : IBaseEntity
    {
        protected IABM<T> context;
        public Repository(IABM<T> _context)
        {
            context = _context;
        }
        public abstract void Save(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);
        public abstract IList<T> ListAll();
    }
}
