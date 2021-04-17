using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServicioBE;
using fw.Servicio.Repositorio;
using Imp.ServicioBE;
using SQL.Provider;
using fw.Interfaces;

namespace Imp.Servicio.Repositorio
{
    public class Traduccion_ServicioRepo : ServicioRepositorio<Traduccion_ServicioBE>
    {
        TraduccionContexto tradContexto = new TraduccionContexto();

        public Traduccion_ServicioRepo() : base(new TraduccionContexto())
        { }

        public override void Alta(Traduccion_ServicioBE BE)
        {
            _Contexto.Alta(BE);
        }

        public override void Baja(Traduccion_ServicioBE BE)
        {
            _Contexto.Baja(BE);
        }

        public override IList<Traduccion_ServicioBE> Listar()
        {
            return _Contexto.Listar();
        }

        public override void Modificar(Traduccion_ServicioBE BE)
        {
            _Contexto.Modificar(BE);
        }

        public IList<Traduccion_ServicioBE> ListarTraduccionesXEtiqueta(Idioma_ServicioBE idiomaBE, Etiqueta_ServicioBE etiquetaBE)
        {
            return tradContexto.ListarTraduccionXEtiqueta(idiomaBE, etiquetaBE);
        }
    }
}
