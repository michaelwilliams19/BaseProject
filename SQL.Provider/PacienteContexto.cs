using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imp.BE;


namespace SQL.Provider
{
    public class PacienteContexto : ContextoSQL<PacienteBE>
    {


        public override void Alta(PacienteBE BE)
        {
            string SentenciaAlta = string.Format("insert into paciente(id,nombre,apellido,fechacreacion, fechaeliminacion) values('{0}','{1}','{2}','{3}','{4}')", BE.ID, BE.Nombre, BE.Apellido, BE.FechaCreacion, BE.FechaEliminacion);
            this.ABM_Asistentes(SentenciaAlta);
        }

        public override void Baja(PacienteBE BE)
        {
            string SentenciaBaja = string.Format("Delete from paciente where id='{0}'", BE.ID);
            this.ABM_Asistentes(SentenciaBaja);
        }

        public override IList<PacienteBE> Listar()
        {
            string SentenciaListar = string.Format("select * from paciente");
            IList<PacienteBE> ListaPacientes = new List<PacienteBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    PacienteBE PaciBE = new PacienteBE();

                    CargarPacientes(PaciBE, fila);
                    ListaPacientes.Add(PaciBE);

                }

            }
            return ListaPacientes;
        }


        public void CargarPacientes(PacienteBE paciBE, System.Data.DataRow Fila)
        {
            paciBE.ID = Convert.ToString(Fila["ID"]);
            paciBE.Nombre = Convert.ToString(Fila["Nombre"]);
            paciBE.Apellido = Convert.ToString(Fila["apellido"]);            
            paciBE.FechaCreacion = Convert.ToString(Fila["FechaCreacion"]);
            paciBE.FechaEliminacion = Convert.ToString(Fila["FechaEliminacion"]);


        }

        public override void Modificar(PacienteBE BE)
        {
            string SentenciaModificar = string.Format("update paciente set nombre='{0}',apellido='{1}' where id= '{2}';", BE.Nombre, BE.Apellido, BE.ID);

            this.ABM_Asistentes(SentenciaModificar);
        }
    }
}
