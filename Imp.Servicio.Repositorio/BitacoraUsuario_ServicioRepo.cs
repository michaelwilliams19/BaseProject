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
    public class BitacoraUsuario_ServicioRepo : ServicioRepositorio<BitacoraUsuario_ServicioBE>
    {

        public BitacoraUsuario_ServicioRepo() : base(new BitacoraUsuarioSQL())
        {

        }

        public override void Alta(BitacoraUsuario_ServicioBE BE)
        {
            _Contexto.Alta(BE);
        }

        public override void Baja(BitacoraUsuario_ServicioBE BE)
        {
            _Contexto.Baja(BE);
        }

        public override IList<BitacoraUsuario_ServicioBE> Listar()
        {
            return _Contexto.Listar();
        }

        public override void Modificar(BitacoraUsuario_ServicioBE BE)
        {
            _Contexto.Modificar(BE);
        }
    }
}
