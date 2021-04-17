using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imp.BE;
using Imp.ServicioBE;


namespace SQL.Provider
{
    public class EspecialidadContexto : ContextoSQL<EspecialidadBE>
    {
        public override void Alta(EspecialidadBE BE)
        {
            string sentenciaAlta = string.Format("Insert into Especialidad(ID,Nombre, FechaCreacion, FechaEliminacion)values('{0}','{1}','{2}','{3}')", BE.ID, BE.Nombre, BE.FechaCreacion, BE.FechaEliminacion);
            this.ABM_Asistentes(sentenciaAlta);
        }

        public override void Baja(EspecialidadBE BE)
        {
            string sentenciaBaja = string.Format("Delete * from especialidad where id='{0}'", BE.ID);
            this.ABM_Asistentes(sentenciaBaja);
        }

        public override IList<EspecialidadBE> Listar()
        {
            string sentenciaListar = string.Format("select * from especialidad");

            IList<EspecialidadBE> ListaEspecialidades = new List<EspecialidadBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(sentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    EspecialidadBE especBE = new EspecialidadBE();

                    CargarEspecialidades(especBE, fila);
                    ListaEspecialidades.Add(especBE);

                }

            }
            return ListaEspecialidades;
        }

        public void CargarEspecialidades(EspecialidadBE especbe, System.Data.DataRow Fila)
        {
            especbe.ID = Convert.ToString(Fila["ID"]);
            especbe.Nombre = Convert.ToString(Fila["Nombre"]);           
            especbe.FechaCreacion = Convert.ToString(Fila["FechaCreacion"]);
            especbe.FechaEliminacion = Convert.ToString(Fila["FechaEliminacion"]);


        }

        public override void Modificar(EspecialidadBE BE)
        {
            string SentenciaModificar = string.Format("update especialidad set nombre='{0}' where id= '{1}';", BE.Nombre, BE.ID);

            this.ABM_Asistentes(SentenciaModificar);
        }
    }
}
