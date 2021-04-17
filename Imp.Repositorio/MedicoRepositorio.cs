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
    public class MedicoRepositorio : Repositorio<MedicoBE>
    {
        public MedicoRepositorio() : base(new MedicoContexto())
        { }
        public override void Alta(MedicoBE BE)
        {
            _contexto.Alta(BE);
        }

        public override void Baja(MedicoBE BE)
        {
            _contexto.Baja(BE);
        }

        public override IList<MedicoBE> Listar()
        {
            return _contexto.Listar();
        }

        public override void Modificar(MedicoBE BE)
        {
            _contexto.Modificar(BE);
        }
    }
}
