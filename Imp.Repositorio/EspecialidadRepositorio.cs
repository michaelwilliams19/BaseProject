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
    public class EspecialidadRepositorio : Repositorio<EspecialidadBE>
    {
        public EspecialidadRepositorio() : base(new EspecialidadContexto())
        { }

        public override void Alta(EspecialidadBE BE)
        {
            _contexto.Alta(BE);
        }

        public override void Baja(EspecialidadBE BE)
        {
            _contexto.Baja(BE);
        }

        public override IList<EspecialidadBE> Listar()
        {
            return _contexto.Listar();
        }

        public override void Modificar(EspecialidadBE BE)
        {
            _contexto.Modificar(BE);
        }
    }
}
