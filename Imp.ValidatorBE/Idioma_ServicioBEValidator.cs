using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imp.BE;
using fw.ServicioBE;
using Imp.ServicioBE;
using System.Collections.Specialized;
using fw.Interfaces;

namespace Imp.ValidatorBE
{
    public class Idioma_ServicioBEValidator : ValidatorAbstracto<Idioma_ServicioBE>
    {
        public override NameValueCollection Validar(Idioma_ServicioBE BE)
        {
            if (string.IsNullOrEmpty(BE.nombreIdioma))
                valueValidator.Add("1", "Debe ingresar el nombre del idioma");

            return valueValidator;
        }
    }
}
