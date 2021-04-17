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
    public class Etiqueta_ServicioRepo : ServicioRepositorio<Etiqueta_ServicioBE>
    {

        public Etiqueta_ServicioRepo() : base(new EtiquetaContexto())
        { }

        public override void Alta(Etiqueta_ServicioBE BE)
        {
            _Contexto.Alta(BE);
        }

        public override void Baja(Etiqueta_ServicioBE BE)
        {
            _Contexto.Baja(BE);
        }

        public override IList<Etiqueta_ServicioBE> Listar()
        {
           return _Contexto.Listar();
        }

        public override void Modificar(Etiqueta_ServicioBE BE)
        {
            _Contexto.Modificar(BE);
        }
    }
}
