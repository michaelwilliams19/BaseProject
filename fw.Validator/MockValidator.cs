using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using fw.Interfaces;
using Imp.ValidatorBE;

namespace fw.Validator
{
    public class MockValidator<T> : ValidatorAbstracto<T> where T : IBaseEntity
    {
        public override NameValueCollection Validar(T BE)
        {
            return valueValidator;
        }
    }
}
