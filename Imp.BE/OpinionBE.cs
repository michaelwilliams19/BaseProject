using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using fw.Interfaces;


namespace Imp.BE
{
    public abstract class OpinionBE : fw.BE.BE
    {

        private string _idForaneo;

        public string idForaneo
        {
            get { return _idForaneo; }
            set { _idForaneo = value; }
        }



    }
}
