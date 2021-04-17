using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using fw.Interfaces;

namespace Imp.BE
{
    public class ComentarioBE : OpinionBE
    {

        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

    }
}
