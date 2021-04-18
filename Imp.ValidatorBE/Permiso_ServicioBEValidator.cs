using Imp.ServicesManagerEntities;
using System.Collections.Specialized;

namespace Imp.ValidatorBE
{
    public class Permiso_ServicioBEValidator : ValidatorAbstracto<Permiso_ServicioBE>
    {
        public override NameValueCollection Validar(Permiso_ServicioBE BE)
        {
            if (string.IsNullOrEmpty(BE.Nombre))
                valueValidator.Add("1", "El permiso debe tener un nombre");

            return valueValidator;
        }
    }
}