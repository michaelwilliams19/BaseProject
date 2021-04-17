using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServicioBE;
using Imp.ServicioBE;


namespace SQL.Provider
{
    public class BitacoraEventosSQL : ContextoSQL<BitacoraBE>
    {
        public override void Alta(BitacoraBE BE)
        {
            string SentenciaAlta = string.Format("insert into Bitacora(Bit_id,Bit_tipoevento,Bit_fechaevento,Bit_FechaEliminacion,Bit_usuarioresponsable)values('{0}','{1}','{2}','{3}','{4}')",
                                          BE.ID, BE.EventoOcurrido, BE.FechaCreacion, BE.FechaEliminacion, BE.UsuarioResponsable);

            this.ABM_Asistentes(SentenciaAlta);
        }

        public override void Baja(BitacoraBE BE)
        {
            throw new NotImplementedException();
        }

        public override IList<BitacoraBE> Listar()
        {
            throw new NotImplementedException();
        }

        public override void Modificar(BitacoraBE BE)
        {
            throw new NotImplementedException();
        }
    }
}
