using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imp.BE;
using Imp.ServicioBE;

namespace SQL.Provider
{
    public class PuntajeContexto : ContextoSQL<PuntajeBE>
    {
        public override void Alta(PuntajeBE BE)
        {
            string sentenciaAlta = string.Format("insert into puntaje(puntajeID, puntajeValor, fechaCreacion, fechaEliminacion, idForaneo, DVH)values('{0}','{1}','{2}','{3}','{4}','{5}')", BE.ID, BE.puntaje, BE.FechaCreacion, BE.FechaEliminacion, BE.idForaneo, BE.dvh);
            this.ABM_Asistentes(sentenciaAlta);
        }

        public override void Baja(PuntajeBE BE)
        {
            throw new NotImplementedException();
        }

        public override IList<PuntajeBE> Listar()
        {
            string SentenciaListar = string.Format("select * from puntaje");
            IList<PuntajeBE> ListaPuntajes = new List<PuntajeBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    PuntajeBE PuntajesBE = new PuntajeBE();

                    CargarPuntajes(PuntajesBE, fila);
                    ListaPuntajes.Add(PuntajesBE);

                }

            }
            return ListaPuntajes;
        }


        public void CargarPuntajes(PuntajeBE Puntbe, System.Data.DataRow Fila)
        {
            Puntbe.ID = Convert.ToString(Fila["PuntajeID"]);
            Puntbe.puntaje = Convert.ToInt32(Fila["PuntajeValor"]);            
            Puntbe.FechaCreacion = Convert.ToString(Fila["FechaCreacion"]);
            Puntbe.FechaEliminacion = Convert.ToString(Fila["FechaEliminacion"]);
            Puntbe.idForaneo = Convert.ToString(Fila["idForaneo"]);
            Puntbe.dvh = Convert.ToString(Fila["DVH"]);

        }


        public override void Modificar(PuntajeBE BE)
        {
            string SentenciaModificar = string.Format("update puntaje set puntajeValor='{0}' where puntajeid= '{1}';", BE.puntaje, BE.ID);


            this.ABM_Asistentes(SentenciaModificar);
        }
    }
}
