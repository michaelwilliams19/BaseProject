using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.ServicioBE;

namespace Imp.ServicioBE
{
    public class Idioma_ServicioBE : fw.ServicioBE.ServicioBE
    {
        public Idioma_ServicioBE()
        {
            this.ID = Convert.ToString(Guid.NewGuid());
        }


        private string _nombreIdioma;

        public string nombreIdioma
        {
            get { return _nombreIdioma; }
            set { _nombreIdioma = value; }
        }


    }
}
