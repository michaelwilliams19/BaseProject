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
    public class TurnoRepositorio : Repositorio<TurnoBE>
    {
        public TurnoRepositorio() : base(new TurnoContexto())
        { }

        public override void Alta(TurnoBE BE)
        {
            _contexto.Alta(BE);
        }

        public override void Baja(TurnoBE BE)
        {
            _contexto.Baja(BE);
        }

        public override IList<TurnoBE> Listar()
        {
            return _contexto.Listar();
        }

        public override void Modificar(TurnoBE BE)
        {
            _contexto.Modificar(BE);
        }
    }
}
