using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServicioBE;
using Imp.ServicioBE;

namespace SQL.Provider
{
    public class IdiomaContexto : ContextoSQL<Idioma_ServicioBE>
    {
        public override void Alta(Idioma_ServicioBE BE)
        {
            
            string SentenciaAlta = string.Format("insert into Idioma(Idioma_id,Idioma_Nombre,Idioma_fechaCreacion,Idioma_fechaEliminacion)values('{0}','{1}','{2}','{3}')", BE.ID, BE.nombreIdioma, BE.FechaCreacion, BE.FechaEliminacion);
            this.ABM_Asistentes(SentenciaAlta);
        }

        public override void Baja(Idioma_ServicioBE BE)
        {
            string SentenciaBaja = string.Format("Delete from Idioma where Idioma_id='{0}'", BE.ID);
            this.ABM_Asistentes(SentenciaBaja);
        }

        public override IList<Idioma_ServicioBE> Listar()
        {

            string SentenciaListar = string.Format("select * from Idioma");
            IList<Idioma_ServicioBE> ListaIdiomas = new List<Idioma_ServicioBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    Idioma_ServicioBE IdiomaBE = new Idioma_ServicioBE();

                    CargarIdioma(IdiomaBE, fila);
                    ListaIdiomas.Add(IdiomaBE);

                }

            }
            return ListaIdiomas;
        }

        public void CargarIdioma(Idioma_ServicioBE IdiomaBE, System.Data.DataRow Fila)
        {
            
            IdiomaBE.ID = Convert.ToString(Fila["Idioma_ID"]);
            IdiomaBE.nombreIdioma = Convert.ToString(Fila["Idioma_Nombre"]);
         
            IdiomaBE.FechaCreacion = Convert.ToString(Fila["Idioma_FechaCreacion"]);
            IdiomaBE.FechaEliminacion = Convert.ToString(Fila["Idioma_FechaEliminacion"]);
         

        }


        public override void Modificar(Idioma_ServicioBE BE)
        {
            string SentenciaModificar = string.Format("update idioma set idioma_nombre='{0}' where id= '{1}';", BE.Nombre, BE.ID);

            this.ABM_Asistentes(SentenciaModificar);
        }
    }
}
