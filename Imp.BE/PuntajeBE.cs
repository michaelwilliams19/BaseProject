using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using fw.Interfaces;

namespace Imp.BE
{
    public class PuntajeBE : OpinionBE
    {
        private int _puntaje;

        public int puntaje
        {
            get { return _puntaje; }
            set { _puntaje = value; }
        }


    }
}
