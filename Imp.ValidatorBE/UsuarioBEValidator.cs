using Imp.Entities;
using System.Collections.Specialized;
using Imp.ServicesManager;
using System.Text.RegularExpressions;

namespace Imp.ValidatorBE
{
    public class UsuarioBEValidator : ValidatorAbstracto<UsuarioBE>
    {
        public override NameValueCollection Validar(UsuarioBE BE)
        {
            Regex miRegex = new Regex("^[a-z]{5}[a-zA-Z0-9.-_]+$");
            MatchCollection miMatchCollection;

            miMatchCollection = miRegex.Matches(BE.nombreUsuario);

            //if (miMatchCollection.Count == 0)
            //    valueValidator.Add("00", "El nombre de usuario debe ser alfanumerico y superior a 5 caracteres");

            if (BE.nombreUsuario.Length > 30)
                valueValidator.Add("001", "El nombre de usuario no debe excederse de los 10 caracteres");

            if (BE == null)
                valueValidator.Add("0", "No tiene seleccionado ningun usuario");

            if (string.IsNullOrEmpty(BE.nombreUsuario))
                valueValidator.Add("1", "El nombre de usuario es obligatorio");

            if (string.IsNullOrEmpty(BE.clave))
                valueValidator.Add("3", "La clave es obligatoria");

            BE.dvh = DVV_BLL.GetDVH(BE);

            DVV_BLL dVV = new DVV_BLL();
            dVV.GenerarDVV();

             return valueValidator;
        }
    }
}