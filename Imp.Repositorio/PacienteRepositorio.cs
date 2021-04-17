using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using Imp.BE;
using fw.Repositorio;
using SQL.Provider;

namespace Imp.Repositorio
{
    public class PacienteRepositorio : Repositorio<PacienteBE>
    {
        public PacienteRepositorio() :base(new PacienteContexto())
        { }


        public override void Alta(PacienteBE BE)
        {
            _contexto.Alta(BE);
        }

        public override void Baja(PacienteBE BE)
        {
            _contexto.Baja(BE);
        }

        public override IList<PacienteBE> Listar()
        {
            return _contexto.Listar();
        }

        public override void Modificar(PacienteBE BE)
        {
            _contexto.Modificar(BE);
        }
    }
}
