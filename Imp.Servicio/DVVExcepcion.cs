using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imp.ServicesManager
{
    public class DVVExcepcion : Exception
    {
        public override string Message
        {
            get
            {
                return "Digito verificador erroneo";
            }
        }
    }
}
