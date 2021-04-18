using System.Collections.Specialized;
using fw.Interfaces;

namespace Imp.ValidatorBE
{
    public abstract class ValidatorAbstracto<T> : IValidator<T> where T : IBaseEntity
    {
        protected NameValueCollection valueValidator = new NameValueCollection();
        public abstract NameValueCollection Validar(T BE);        
    }
}