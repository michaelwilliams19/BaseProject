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
    public class EspecialidadBEValidator : ValidatorAbstracto<EspecialidadBE>
    {
        public override NameValueCollection Validar(EspecialidadBE BE)
        {
            if (string.IsNullOrEmpty(BE.Nombre))
                valueValidator.Add("1", "Debe ingresar un nombre para la especialidad");

            return valueValidator;                    
        }
    }
}
