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
    public class ComentarioRepositorio : Repositorio<ComentarioBE>
    {

        public ComentarioRepositorio() : base(new ComentarioContexto())
        { }

        public override void Alta(ComentarioBE BE)
        {
            _contexto.Alta(BE);
        }

        public override void Baja(ComentarioBE BE)
        {
            _contexto.Baja(BE);
        }

        public override IList<ComentarioBE> Listar()
        {
            return _contexto.Listar();
        }

        public override void Modificar(ComentarioBE BE)
        {
            _contexto.Modificar(BE);
        }
    }
}
