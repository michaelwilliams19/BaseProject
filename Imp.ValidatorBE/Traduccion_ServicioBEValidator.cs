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
    public class Traduccion_ServicioBEValidator : ValidatorAbstracto<Traduccion_ServicioBE>
    {
        public override NameValueCollection Validar(Traduccion_ServicioBE BE)
        {
            if (string.IsNullOrEmpty(BE.palabraTraducida))
                valueValidator.Add("1", "La traduccion no puede estar vacia");

            return valueValidator;
        }
    }
}
