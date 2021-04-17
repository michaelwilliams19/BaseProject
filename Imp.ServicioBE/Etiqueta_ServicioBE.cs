using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.ServicioBE;

namespace Imp.ServicioBE
{
    public class Etiqueta_ServicioBE : fw.ServicioBE.ServicioBE
    {

        public Etiqueta_ServicioBE() 
        {
            this.ID = Convert.ToString(Guid.NewGuid());
        }


        private string _nombreEtiqueta;

        public string NombreEtiqueta
        {
            get { return _nombreEtiqueta; }
            set { _nombreEtiqueta = value; }
        }


    }
}
