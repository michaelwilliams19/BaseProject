using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using Imp.BE;
using fw.Repositorio;
using SQL.Provider;
using Imp.ServicioBE;

namespace Imp.Repositorio
{
    public class PuntajeRepositorio : Repositorio<PuntajeBE>
    {
        public PuntajeRepositorio() : base(new PuntajeContexto())
        { }

        public override void Alta(PuntajeBE BE)
        {
            _contexto.Alta(BE);
        }

        public override void Baja(PuntajeBE BE)
        {
            _contexto.Baja(BE);
        }

        public override IList<PuntajeBE> Listar()
        {
            return _contexto.Listar();
        }

        public override void Modificar(PuntajeBE BE)
        {
            _contexto.Modificar(BE);
        }
    }
}
