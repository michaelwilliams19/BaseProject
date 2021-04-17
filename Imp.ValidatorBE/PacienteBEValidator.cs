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
    public class PacienteBEValidator : ValidatorAbstracto<PacienteBE>
    {
        public override NameValueCollection Validar(PacienteBE BE)
        {          

            if (string.IsNullOrEmpty(BE.Nombre))
                valueValidator.Add("1", "El campo de nombre es obligatorio");

            if (string.IsNullOrEmpty(BE.Apellido))
                valueValidator.Add("2", "El campo de apellido es obligatorio");

            //if (string.IsNullOrEmpty(BE.DNI))
            //    valueValidator.Add("3", "El campo de dni es obligatorio");

            return valueValidator;
        }
    }
}
