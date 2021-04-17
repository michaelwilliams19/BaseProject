using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServicioBE;
using fw.Interfaces;

namespace Imp.ServicioBE
{
    public class Permiso_ServicioBE : fw.ServicioBE.ServicioBE
    {

        //public static List<PermisoBE> listaHijos = new List<PermisoBE>();


        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }


        private List<Permiso_ServicioBE> _listahijos;
        public List<Permiso_ServicioBE> listaHijos
        {
            get { return _listahijos; }
            set { _listahijos = value; }
        }

     










    }
}
