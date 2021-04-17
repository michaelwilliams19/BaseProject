using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.ServicioBE;

namespace Imp.ServicioBE
{
    public class Traduccion_ServicioBE : fw.ServicioBE.ServicioBE
    {

        public Traduccion_ServicioBE()
        {
            this.ID = Convert.ToString(Guid.NewGuid());
        }



        private string _codEtiqueta;

        public string codEtiqueta
        {
            get { return _codEtiqueta; }
            set { _codEtiqueta = value; }
        }

        private string _codIdioma;

        public string codIdioma
        {
            get { return _codIdioma; }
            set { _codIdioma = value; }
        }

        private string _palabraTraducida;

        public string palabraTraducida
        {
            get { return _palabraTraducida; }
            set { _palabraTraducida = value; }
        }




    }
}
