using System.Collections.Generic;
using fw.Interfaces;

namespace fw.ServiceManager.Repositories
{
    public abstract class ServiceManagerRepository<T> : IABM<T> where T : IBaseEntity
    {
        protected IABM<T> context;

        public ServiceManagerRepository(IABM<T> _context)
        {
            context = _context;
        }

        public abstract void Save(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);
        public abstract IList<T> ListAll();
    }
}