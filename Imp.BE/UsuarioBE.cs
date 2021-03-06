using System;
using fw.Interfaces;

namespace Imp.Entities
{
    public class UsuarioBE : IUsuario
    {
        public string ID { get; set; }
        public string nombreUsuario { get; set; }
        public string clave { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaEliminacion { get; set; }
        public string dvh { get; set; }
    }
}