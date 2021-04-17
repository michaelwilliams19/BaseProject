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
    public class SingletonIdioma
    {

        private static SingletonIdioma _SesionIdioma;

        private Idioma_ServicioBE idiomaON;

        protected SingletonIdioma() { }



        public void relacionarIdioma(Idioma_ServicioBE idiomaNuevo)
        {
            idiomaON = idiomaNuevo;
        }



        public Idioma_ServicioBE devolverIdiomaActivo()
        {
            return idiomaON;
        }


        public static SingletonIdioma InstanciaIdioma
        {
            get
            {
                if (_SesionIdioma == null)
                {
                    _SesionIdioma = new SingletonIdioma();
                }

            return _SesionIdioma;
            }
        }

    }
}
