using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using Imp.BE;
using System.Collections.Specialized;
using fw.Interfaces;
using fw.Servicio;
using Imp.Servicio;
using System.Text.RegularExpressions;

namespace Imp.ValidatorBE
{
    public class UsuarioBEValidator : ValidatorAbstracto<UsuarioBE>
    {


        public override NameValueCollection Validar(UsuarioBE BE)
        {
            Regex miRegex = new Regex("^[a-z]{5}[a-zA-Z0-9.-_]+$");
            MatchCollection miMatchCollection;

            miMatchCollection = miRegex.Matches(BE.NombreUsuario);
                     
            
            //if (miMatchCollection.Count == 0)
            //    valueValidator.Add("00", "El nombre de usuario debe ser alfanumerico y superior a 5 caracteres");

            if (BE.NombreUsuario.Length > 30)
                valueValidator.Add("001", "El nombre de usuario no debe excederse de los 10 caracteres");

            if (BE == null)
                valueValidator.Add("0", "No tiene seleccionado ningun usuario");

            if (string.IsNullOrEmpty(BE.NombreUsuario))
                valueValidator.Add("1", "El nombre de usuario es obligatorio");

            if (string.IsNullOrEmpty(BE.Nombre))
                valueValidator.Add("2", "El nombre es obligatorio");

            if (string.IsNullOrEmpty(BE.Clave))
                valueValidator.Add("3", "La clave es obligatoria");

            BE.dvh = DVV_BLL.GetDVH(BE);

            DVV_BLL dVV = new DVV_BLL();
            dVV.GenerarDVV();


             return valueValidator;
        }
    }
}
