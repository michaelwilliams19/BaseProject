using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;

namespace Imp.ValidatorBE
{
    public abstract class ValidatorAbstracto<T> : IValidator<T> where T : IBaseEntity
    {

        protected NameValueCollection valueValidator = new NameValueCollection();

        public abstract NameValueCollection Validar(T BE);
        
    }
}
