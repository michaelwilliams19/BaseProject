using fw.Interfaces;

namespace fw.Security
{
    public class Singleton
    {
        private static Singleton _SesionActiva;
        private IUsuario UsuarioOn;

        protected Singleton() { }

        public void RelacionarUsuario(IUsuario usuario)
        {
            UsuarioOn = usuario;
        }

        public IUsuario DevolverUsuarioActivo()
        {
            return UsuarioOn;
        }

        public static Singleton Instancia
        {
            get
            {
                return _SesionActiva == null ? new Singleton() : _SesionActiva;
            }
        }

        public void EliminarInstancia()
        {
            _SesionActiva = null;
        }
    }
}






