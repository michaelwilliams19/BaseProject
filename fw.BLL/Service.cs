using System.Collections.Generic;
using fw.Interfaces;
using Imp.Validator;

namespace fw.Services
{
    public abstract class Service<T> : IABM<T> where T : IBaseEntity
    {
        IABM<T> Repository;

        public Service(IABM<T> _Repository)
        {
            Repository = _Repository;
        }
        public virtual void Save(T entity)
        {
            entity.Validar();
            Repository.Save(entity);
        }

        public virtual void Update(T entity)
        {
            entity.Validar();
            Repository.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            Repository.Delete(entity);
        }

        public virtual IList<T> ListAll()
        {
            return Repository.ListAll();
        }
    }
}