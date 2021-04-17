using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.ServicioBE;
using Imp.ServicioBE;

namespace fw.Seguridad
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
                if (_SesionActiva == null)
                {
                    _SesionActiva = new Singleton();
                }
                return _SesionActiva;
            }
        }                               
        

        public void EliminarInstancia()
        {
            _SesionActiva = null;
            
        }
    }
    }





    
