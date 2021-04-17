using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using System.Collections.Specialized;

namespace Imp.Validator
{
    public static class ValidatorGeneral
    {

        public static bool Validar<T>(this T BE) where T : IBaseEntity
        {

            var validator = ValidatorFactory.ObtenerValidator<T>();

            var nvc = validator.Validar(BE);

            if (nvc.Count > 0)
               throw new ValidatorException(nvc);

            return true;
        }


    }
}
