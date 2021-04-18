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
