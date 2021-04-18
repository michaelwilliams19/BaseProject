using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServiceManagerEntities;
using Imp.ServicesManagerEntities;

namespace SQL.Provider
{
    public class BitacoraUsuarioSQL : ContextoSQL<BitacoraUsuario_ServicioBE>
    {
        public override void Save(BitacoraUsuario_ServicioBE BE)
        {
            BE.BitacoraID = Convert.ToString(Guid.NewGuid());
            string SentenciaAlta = string.Format("insert into BitacoraUsuario(Bitacora_id,bitacora_IDusuario,bitacora_nombre, bitacora_nombreUsuario, bitacora_clave, bitacora_fechacreacion, bitacora_fechaeliminacion,bitacora_fechamodificacion, bitacora_usuarioresponsable) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",BE.BitacoraID, BE.ID, BE.nombre, BE.nombreUsuario, BE.clave, BE.FechaCreacion, BE.FechaEliminacion,BE.FechaModificacion,BE.UsuarioResponsable);
            this.ABM_Asistentes(SentenciaAlta);
        }

        public override void Delete(BitacoraUsuario_ServicioBE BE)
        {
            string SentenciaBaja = string.Format("Delete from BitacoraUsuario where bitacora_id='{0}'", BE.ID);
            this.ABM_Asistentes(SentenciaBaja);
        }

        public override IList<BitacoraUsuario_ServicioBE> ListAll()
        {
            string SentenciaListar = string.Format("select * from bitacoraUsuario");
            IList<BitacoraUsuario_ServicioBE> ListaBitacoraUsuario = new List<BitacoraUsuario_ServicioBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    BitacoraUsuario_ServicioBE BitacoraUsuarioBE = new BitacoraUsuario_ServicioBE();

                    CargarUsuarioBitacora(BitacoraUsuarioBE, fila);
                    ListaBitacoraUsuario.Add(BitacoraUsuarioBE);

                }

            }
            return ListaBitacoraUsuario;
        }

        public void CargarUsuarioBitacora(BitacoraUsuario_ServicioBE bitacoraUsuario, System.Data.DataRow Fila)
        {
            bitacoraUsuario.BitacoraID = Convert.ToString(Fila["Bitacora_ID"]);
            bitacoraUsuario.ID = Convert.ToString(Fila["Bitacora_IDusuario"]);
            bitacoraUsuario.nombre = Convert.ToString(Fila["Bitacora_Nombre"]);
            bitacoraUsuario.nombreUsuario = Convert.ToString(Fila["Bitacora_NombreUsuario"]);
            bitacoraUsuario.clave = Convert.ToString(Fila["Bitacora_Clave"]);
            bitacoraUsuario.FechaCreacion = Convert.ToString(Fila["Bitacora_FechaCreacion"]);
            bitacoraUsuario.FechaEliminacion = Convert.ToString(Fila["Bitacora_FechaEliminacion"]);
            bitacoraUsuario.FechaModificacion= Convert.ToString(Fila["Bitacora_FechaModificacion"]);
            bitacoraUsuario.UsuarioResponsable = Convert.ToString(Fila["Bitacora_UsuarioResponsable"]);

        }



        public override void Update(BitacoraUsuario_ServicioBE BE)
        {
            throw new NotImplementedException();
        }



        public int ObtenerProximoID()
        {
            int resultado = 0;

            string SentenciaID = string.Format("select isnull(max(bitacora_id),0) from bitacoraUsuario");

            resultado = this.ObtenerID(SentenciaID);
            resultado += 1;

            return resultado;


        }



    }
}
