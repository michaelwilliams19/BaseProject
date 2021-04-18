using System.Collections.Generic;
using fw.Interfaces;

namespace fw.ServiceManager.Services
{
    public abstract class ServiceManager<T> : IABM<T> where T : IBaseEntity
    {
        IABM<T> _RepositoryService;
        public ServiceManager(IABM<T> RepositoryServicio)
        {
            _RepositoryService = RepositoryServicio;
        }

        public void Save(T entity)
        {
            _RepositoryService.Save(entity);
        }
        public void Update(T entity)
        {
            _RepositoryService.Update(entity);
        }

        public void Delete(T entity)
        {
            _RepositoryService.Delete(entity);
        }

        public IList<T> ListAll()
        {
            return _RepositoryService.ListAll();
        }
    }
}