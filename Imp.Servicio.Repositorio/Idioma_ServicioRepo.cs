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
    public class Idioma_ServicioRepo : ServicioRepositorio<Idioma_ServicioBE>
    {

        public Idioma_ServicioRepo() : base(new IdiomaContexto())
        { }


        public override void Alta(Idioma_ServicioBE BE)
        {
            _Contexto.Alta(BE);
        }

        public override void Baja(Idioma_ServicioBE BE)
        {
            _Contexto.Baja(BE);
        }

        public override IList<Idioma_ServicioBE> Listar()
        {
            return _Contexto.Listar();
        }

        public override void Modificar(Idioma_ServicioBE BE)
        {
            _Contexto.Modificar(BE);
        }
    }
}
