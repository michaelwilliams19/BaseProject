using Imp.ServicesManagerEntities;
using System.Collections.Specialized;

namespace Imp.ValidatorBE
{
    public class Familia_ServicioBEValidator : ValidatorAbstracto<Familia_ServicioBE>
    {
        public override NameValueCollection Validar(Familia_ServicioBE BE)
        {
            if (string.IsNullOrEmpty(BE.Nombre))
                valueValidator.Add("1", "El permiso debe tener un nombre");

            return valueValidator;                    
        }
    }
}