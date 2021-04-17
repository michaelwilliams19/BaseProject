using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using System.Collections.Specialized;

namespace fw.Interfaces
{
    public interface IValidator<T> where T :IBaseEntity
    {

        NameValueCollection Validar(T BE);


    }
}
