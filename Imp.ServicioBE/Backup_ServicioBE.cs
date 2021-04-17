using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.ServicioBE;

namespace Imp.ServicioBE
{
    public class Backup_ServicioBE : fw.ServicioBE.ServicioBE
    {

        private string _NombreBackup;
        public string NombreBackup
        {
            get { return _NombreBackup; }
            set { _NombreBackup = value; }
        }


        private string _ruta;
        public string Ruta
        {
            get { return _ruta; }
            set { _ruta = value; }
        }


    }
}
