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
