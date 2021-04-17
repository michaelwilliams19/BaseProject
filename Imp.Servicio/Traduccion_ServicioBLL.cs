using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.Servicio.BLL;
using Imp.Servicio.Repositorio;
using fw.ServicioBE;
using Imp.ServicioBE;

namespace Imp.Servicio
{
    public class Traduccion_ServicioBLL : Servicio<Traduccion_ServicioBE>
    {
        Traduccion_ServicioRepo tradRepositorio = new Traduccion_ServicioRepo();

        public Traduccion_ServicioBLL() : base(new Traduccion_ServicioRepo())
        { }

        public Boolean comprobarTraduccionXEtiqueta(Idioma_ServicioBE idiomaBE, Etiqueta_ServicioBE etiquetaBE)
        {
            return true;

        }


        public IList<Traduccion_ServicioBE> ListarTraduccionesXEtiqueta(Idioma_ServicioBE idiomaBE, Etiqueta_ServicioBE etiquetaBE)
        {
            return tradRepositorio.ListarTraduccionesXEtiqueta(idiomaBE, etiquetaBE);
        }


    }
}
