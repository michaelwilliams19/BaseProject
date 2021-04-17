using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServicioBE;
using fw.Interfaces;

namespace Imp.ServicioBE
{
    public class BitacoraUsuario_ServicioBE : fw.ServicioBE.ServicioBE, IUsuario
    {

        

        private string _NombreUsuario;
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }


        private string _Clave;
        public string Clave { get => _Clave; set => _Clave = value; }



        private string _BitacoraID;
        public string BitacoraID
        {
            get { return _BitacoraID; }
            set { _BitacoraID = value; }
        }
               

        private string _FechaModificacion;
        public string FechaModificacion
        {
            get { return _FechaModificacion; }
            set { _FechaModificacion = value; }
        }


        private string _UsuarioResponsable;
        public string UsuarioResponsable
        {
            get { return _UsuarioResponsable; }
            set { _UsuarioResponsable = value; }
        }

    }
}
