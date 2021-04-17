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
    public class Bitacora_ServicioRepo : ServicioRepositorio<BitacoraBE>
    {

        public Bitacora_ServicioRepo() : base(new BitacoraEventosSQL())
        {

        }

        public override void Alta(BitacoraBE BE)
        {
            _Contexto.Alta(BE);
        }

        public override void Baja(BitacoraBE BE)
        {
            _Contexto.Baja(BE);
        }

        public override IList<BitacoraBE> Listar()
        {
            return _Contexto.Listar();
        }

        public override void Modificar(BitacoraBE BE)
        {
            _Contexto.Modificar(BE);
        }
    }
}
