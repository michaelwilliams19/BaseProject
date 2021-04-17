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
    public class DVV_Repositorio : ServicioRepositorio<DVV_BE>
    {
        public DVV_Repositorio() : base(new DVVContexto())
        {}

        public override void Alta(DVV_BE BE)
        {
            _Contexto.Alta(BE);
        }

        public override void Baja(DVV_BE BE)
        {
            _Contexto.Baja(BE);
        }

        public override IList<DVV_BE> Listar()
        {
            return _Contexto.Listar();
        }

        public override void Modificar(DVV_BE BE)
        {
            _Contexto.Modificar(BE);
        }
    }
}
