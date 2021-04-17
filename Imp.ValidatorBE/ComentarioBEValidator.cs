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
    public class ComentarioBEValidator : ValidatorAbstracto<ComentarioBE>
    {
        public override NameValueCollection Validar(ComentarioBE BE)
        {
            if (string.IsNullOrEmpty(BE.descripcion))
                valueValidator.Add("1", "Debe ingresar un comentario");

            return valueValidator;

        }
    }
}
