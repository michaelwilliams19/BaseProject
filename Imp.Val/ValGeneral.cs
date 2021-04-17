using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imp.Validator;
using fw.Interfaces;

namespace Imp.Val
{
    public static class ValGeneral
    {

        public static bool validarVal(IBaseEntity BE)
        {
            ValidatorGeneral.Validar(BE);
            return true;
        }
            //public static bool Validar<T>(this T BE) where T : IBaseEntity
            //{

            //    var validator = ValidatorFactory.ObtenerValidator<T>();

            //    var nvc = validator.Validar(BE);

            //    if (nvc.Count > 0)
            //        throw new ValidatorException(nvc);

            //    return true;
            //}


     
    }
}
