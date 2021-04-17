using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServicioBE;
using Imp.ServicioBE;

namespace SQL.Provider
{
    public class EtiquetaContexto : ContextoSQL<Etiqueta_ServicioBE>
    {
        public override void Alta(Etiqueta_ServicioBE BE)
        {
            string SentenciaAlta = string.Format("insert into Etiqueta(Etiqueta_id,Etiqueta_Nombre,Etiqueta_fechaCreacion,Etiqueta_fechaEliminacion)values('{0}','{1}','{2}','{3}')", BE.ID, BE.NombreEtiqueta, BE.FechaCreacion, BE.FechaEliminacion);
            this.ABM_Asistentes(SentenciaAlta);
        }

        public override void Baja(Etiqueta_ServicioBE BE)
        {
            string SentenciaBaja = string.Format("Delete from Etiqueta where Etiqueta_id='{0}'", BE.ID);
            this.ABM_Asistentes(SentenciaBaja);
        }

        public override IList<Etiqueta_ServicioBE> Listar()
        {
            IList<Etiqueta_ServicioBE> ListaEtiquetas = new List<Etiqueta_ServicioBE>();
            try
            {
                string SentenciaListar = string.Format("select * from Etiqueta");                

                System.Data.DataSet MiDataset = new System.Data.DataSet();

                MiDataset = this.CargarDataset(SentenciaListar);

                if (MiDataset.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                    {
                        Etiqueta_ServicioBE EtiquetaBE = new Etiqueta_ServicioBE();

                        CargarEtiqueta(EtiquetaBE, fila);
                        ListaEtiquetas.Add(EtiquetaBE);

                    }

                }
            }
            catch (Exception)
            {
                
            }
            
            return ListaEtiquetas;
        }

        public void CargarEtiqueta(Etiqueta_ServicioBE EtiquetaBE, System.Data.DataRow Fila)
        {

            EtiquetaBE.ID = Convert.ToString(Fila["Etiqueta_ID"]);
            EtiquetaBE.NombreEtiqueta = Convert.ToString(Fila["Etiqueta_Nombre"]);

            EtiquetaBE.FechaCreacion = Convert.ToString(Fila["Etiqueta_FechaCreacion"]);
            EtiquetaBE.FechaEliminacion = Convert.ToString(Fila["Etiqueta_FechaEliminacion"]);


        }



        public override void Modificar(Etiqueta_ServicioBE BE)
        {
            string SentenciaModificar = string.Format("update etiqueta set etiqueta_nombre='{0}' where etiqueta_id= '{1}';", BE.Nombre, BE.ID);

            this.ABM_Asistentes(SentenciaModificar);
        }
    }
}
