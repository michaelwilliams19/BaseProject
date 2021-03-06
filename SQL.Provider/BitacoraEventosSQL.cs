using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServiceManagerEntities;
using Imp.ServicesManagerEntities;


namespace SQL.Provider
{
    public class BitacoraEventosSQL : ContextoSQL<BitacoraBE>
    {
        public override void Save(BitacoraBE BE)
        {
            string SentenciaAlta = string.Format("insert into Bitacora(Bit_id,Bit_tipoevento,Bit_fechaevento,Bit_FechaEliminacion,Bit_usuarioresponsable)values('{0}','{1}','{2}','{3}','{4}')",
                                          BE.ID, BE.EventoOcurrido, BE.fechaCreacion, BE.fechaEliminacion, BE.UsuarioResponsable);

            this.ABM_Asistentes(SentenciaAlta);
        }

        public override void Delete(BitacoraBE BE)
        {
            throw new NotImplementedException();
        }

        public override IList<BitacoraBE> ListAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(BitacoraBE BE)
        {
            throw new NotImplementedException();
        }
    }
}
