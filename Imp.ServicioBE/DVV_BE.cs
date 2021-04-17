using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.ServicioBE;

namespace Imp.ServicioBE
{
   public class DVV_BE : fw.ServicioBE.ServicioBE
   {

        private string _digitoVerificador;
        public string digitoVerificador
        {
            get { return _digitoVerificador; }
            set { _digitoVerificador = value; }
        }



    }
}
