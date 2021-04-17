using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using Imp.BE;
using System.Collections.Specialized;
using fw.Interfaces;


namespace Imp.ValidatorBE
{
    public class PuntajeBEValidator : ValidatorAbstracto<PuntajeBE>
    {
        public override NameValueCollection Validar(PuntajeBE BE)
        {

            if (string.IsNullOrEmpty(Convert.ToString(BE.puntaje)))
                valueValidator.Add("1", "Debe ingresar un puntaje");

            return valueValidator;
        }
    }
}
