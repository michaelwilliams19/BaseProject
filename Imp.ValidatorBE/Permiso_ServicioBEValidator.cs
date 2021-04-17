using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using Imp.BE;
using fw.ServicioBE;
using Imp.ServicioBE;
using System.Collections.Specialized;
using fw.Interfaces;

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
