using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using fw.Interfaces;

namespace Imp.Validator
{
    public class ValidatorException : Exception
    {

        NameValueCollection valueValidatorException;

        public ValidatorException(string clave, string valor)
        {
            valueValidatorException = new NameValueCollection();
            valueValidatorException.Add(clave, valor);

        }

        public ValidatorException(NameValueCollection _valueValidator)
        {

            valueValidatorException = _valueValidator;

        }

        public override string Message
        {
            get
            {
                return string.Join(", \n ", valueValidatorException.AllKeys.ToDictionary(x => x, x => valueValidatorException[x]));
            }

        }


    }
}
