using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServicioBE;
using Imp.ServicioBE;
using Imp.BE;

namespace SQL.Provider
{
    public class ComentarioContexto : ContextoSQL<ComentarioBE>
    {
        public override void Alta(ComentarioBE BE)
        {
            string sentenciaAlta = string.Format("Insert into Comentario(comentarioID, descripcion,fechaCreacion, fechaEliminacion, idForaneo)values('{0}','{1}','{2}','{3}','{4}')", BE.ID, BE.descripcion,BE.FechaCreacion,BE.FechaEliminacion, BE.idForaneo);
            this.ABM_Asistentes(sentenciaAlta);


        }

        public override void Baja(ComentarioBE BE)
        {
            throw new NotImplementedException();
        }

        public override IList<ComentarioBE> Listar()
        {
            string SentenciaListar = string.Format("select * from comentario");
            IList<ComentarioBE> ListaComentarios = new List<ComentarioBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    ComentarioBE ComentBE = new ComentarioBE();

                    CargarComentarios(ComentBE, fila);
                    ListaComentarios.Add(ComentBE);

                }

            }
            return ListaComentarios;
        }


        public void CargarComentarios(ComentarioBE Puntbe, System.Data.DataRow Fila)
        {
            Puntbe.ID = Convert.ToString(Fila["ComentarioID"]);
            Puntbe.descripcion = Convert.ToString(Fila["descripcion"]);
            Puntbe.FechaCreacion = Convert.ToString(Fila["FechaCreacion"]);
            Puntbe.FechaEliminacion = Convert.ToString(Fila["FechaEliminacion"]);
            Puntbe.idForaneo = Convert.ToString(Fila["idForaneo"]);
        }


        public override void Modificar(ComentarioBE BE)
        {
            string SentenciaModificar = string.Format("update comentario set descripcion='{0}' where Comentarioid= '{1}';", BE.descripcion, BE.ID);

            this.ABM_Asistentes(SentenciaModificar);
        }
    }
}
