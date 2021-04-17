using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using fw.Interfaces;


namespace Imp.BE
{
    public class UsuarioBE : IUsuario
    {


        public UsuarioBE()
        {
            

        }



        private string _nombre;
        public string Nombre { get => _nombre; set => _nombre = value; }

        private string _NombreUsuario;
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }

        private string _Clave;
        public string Clave { get => _Clave; set => _Clave = value; }

        private string _ID;
        public string ID { get => _ID; set => _ID = value; }

        private string _FechaCreacion;
        public string FechaCreacion { get => _FechaCreacion; set => _FechaCreacion=value; }

        private string _FechaEliminacion;
        public string FechaEliminacion { get => _FechaEliminacion; set => _FechaEliminacion = value; }

        private string _dvh;
        public string dvh { get => _dvh; set => _dvh = value; }

    }
}
