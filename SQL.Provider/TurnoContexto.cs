using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imp.BE;
using Imp.ServicioBE;

namespace SQL.Provider
{
    public class TurnoContexto : ContextoSQL<TurnoBE>
    {
        public override void Alta(TurnoBE BE)
        {
            string SentenciaAlta = string.Format("insert into turno(id,usuarioID,pacienteID,fechaTurno,fechacreacion, fechaeliminacion) values('{0}','{1}','{2}','{3}','{4}','{5}')", BE.ID, BE.usuarioID, BE.pacienteID,BE.fechaTurno, BE.FechaCreacion, BE.FechaEliminacion);
            this.ABM_Asistentes(SentenciaAlta);
        }

        public override void Baja(TurnoBE BE)
        {
            string SentenciaBaja = string.Format("Delete from turno where id='{0}'", BE.ID);
            this.ABM_Asistentes(SentenciaBaja);
        }

        public override IList<TurnoBE> Listar()
        {
            string SentenciaListar = string.Format("select * from turno");
            List<TurnoBE> ListaTurnos = new List<TurnoBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    TurnoBE UsuBE = new TurnoBE();

                    CargarTurnos(UsuBE, fila);
                    ListaTurnos.Add(UsuBE);

                }

            }
            return ListaTurnos;
        }

        public void CargarTurnos(TurnoBE usube, System.Data.DataRow Fila)
        {
            usube.ID = Convert.ToString(Fila["ID"]);
            usube.usuarioID = Convert.ToString(Fila["usuarioID"]);
            usube.pacienteID = Convert.ToString(Fila["pacienteID"]);
            usube.fechaTurno = Convert.ToString(Fila["fechaTurno"]);
            usube.FechaCreacion = Convert.ToString(Fila["FechaCreacion"]);
            usube.FechaEliminacion = Convert.ToString(Fila["FechaEliminacion"]);


        }

        public override void Modificar(TurnoBE BE)
        {
            throw new NotImplementedException();
        }
    }
}
