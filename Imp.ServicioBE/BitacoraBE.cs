using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.ServicioBE;


namespace Imp.ServicioBE 
{
    public class BitacoraBE : fw.ServicioBE.ServicioBE
    {

        private string _UsuarioResponsable;

        public string UsuarioResponsable
        {
            get { return _UsuarioResponsable; }
            set { _UsuarioResponsable = value; }
        }

        private TipoEvento _EventoOcurrido;
        public TipoEvento EventoOcurrido
        {
            get { return _EventoOcurrido; }
            set { _EventoOcurrido = value; }
        }

        public enum TipoEvento
        {
            Login=1,
            Logout=2,
            Backup=3,
            Restore=4
        };




    }
}
