using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServicioBE;
using Imp.ServicioBE;


namespace SQL.Provider
{
    public class TraduccionContexto : ContextoSQL<Traduccion_ServicioBE>
    {
        public override void Alta(Traduccion_ServicioBE BE)
        {
            string SentenciaAlta = string.Format("insert into Traduccion(traduccion_id,traduccion_codIdioma,traduccion_codEtiqueta,traduccion_palabraTraducida,traduccion_fechaCreacion,traduccion_fechaEliminacion,dvh)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", BE.ID, BE.codIdioma, BE.codEtiqueta, BE.palabraTraducida,BE.FechaCreacion,BE.FechaEliminacion, BE.dvh);
            this.ABM_Asistentes(SentenciaAlta);
        }

        public override void Baja(Traduccion_ServicioBE BE)
        {
            string SentenciaBaja = string.Format("Delete from traduccion where traduccion_id='{0}'", BE.ID);
            this.ABM_Asistentes(SentenciaBaja);
        }

        public override IList<Traduccion_ServicioBE> Listar()
        {
            string SentenciaListar = string.Format("select * from Traduccion");
            IList<Traduccion_ServicioBE> ListaTraducciones = new List<Traduccion_ServicioBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    Traduccion_ServicioBE TraduccionBE = new Traduccion_ServicioBE();

                    CargarTraduccion(TraduccionBE, fila);
                    ListaTraducciones.Add(TraduccionBE);

                }

            }
            return ListaTraducciones;
        }


        public void CargarTraduccion(Traduccion_ServicioBE TraduccionBE, System.Data.DataRow Fila)
        {

            TraduccionBE.ID = Convert.ToString(Fila["Traduccion_ID"]);
            TraduccionBE.codIdioma= Convert.ToString(Fila["Traduccion_codIdioma"]);
            TraduccionBE.codEtiqueta = Convert.ToString(Fila["Traduccion_codEtiqueta"]);
            TraduccionBE.palabraTraducida = Convert.ToString(Fila["Traduccion_palabraTraducida"]);

            TraduccionBE.FechaCreacion = Convert.ToString(Fila["Traduccion_FechaCreacion"]);
            TraduccionBE.FechaEliminacion = Convert.ToString(Fila["Traduccion_FechaEliminacion"]);
            TraduccionBE.dvh = Convert.ToString(Fila["DVH"]);


        }

        public  IList<Traduccion_ServicioBE> ListarTraduccionXEtiqueta(Idioma_ServicioBE idiomaBE, Etiqueta_ServicioBE etiquetaBE)
        {
            string SentenciaListar = string.Format("select * from Traduccion where traduccion_codIdioma = '{0}' and traduccion_codEtiqueta = '{1}'", idiomaBE.ID, etiquetaBE.ID); ;
            IList<Traduccion_ServicioBE> ListaTraducciones = new List<Traduccion_ServicioBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    Traduccion_ServicioBE TraduccionBE = new Traduccion_ServicioBE();

                    CargarTraduccion(TraduccionBE, fila);
                    ListaTraducciones.Add(TraduccionBE);

                }

            }
            return ListaTraducciones;
        }




        public override void Modificar(Traduccion_ServicioBE BE)
        {
            string SentenciaModificar = string.Format("update traduccion set traduccion_codIdioma='{0}',traduccion_codEtiqueta='{1}',traduccion_palabraTraducida='{2}' where id= '{3}';", BE.Nombre, BE.codIdioma, BE.codEtiqueta, BE.ID);

            this.ABM_Asistentes(SentenciaModificar);
        }
    }
}
