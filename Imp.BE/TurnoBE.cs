using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using fw.Interfaces;

namespace Imp.BE
{
    public class TurnoBE : fw.BE.BE
    {

        private string _usuarioID;
        public string usuarioID
        {
            get { return _usuarioID; }
            set { _usuarioID = value; }
        }

        private string _pacienteID;
        public string pacienteID
        {
            get { return _pacienteID; }
            set { _pacienteID = value; }
        }

        private string _fechaTurno;
        public string fechaTurno
        {
            get { return _fechaTurno; }
            set { _fechaTurno = value; }
        }





    }
}
