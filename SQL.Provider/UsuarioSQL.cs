
using System;
using System.Collections.Generic;
using Imp.Entities;
using Imp.ServicesManagerEntities;

namespace SQL.Provider
{
    public class UsuarioSQL : ContextoSQL<UsuarioBE>
    {

        public UsuarioSQL()
        { }


        public override void Save(UsuarioBE BE)
        {


            string SentenciaAlta = string.Format("insert into usuario(id,nombreUsuario,clave,fechacreacion, fechaeliminacion,DVH) values('{0}','{1}','{2}','{3}','{4}','{5}')", Convert.ToString(ObtenerProximoID()), BE.nombreUsuario, BE.clave, BE.fechaCreacion, BE.fechaEliminacion, BE.dvh);
            this.ABM_Asistentes(SentenciaAlta);
            persistirDVV("Usuario");

        }

        public override void Delete(UsuarioBE BE)
        {
            string SentenciaBaja = string.Format("Delete from usuario where id='{0}'", BE.ID);
            this.ABM_Asistentes(SentenciaBaja);
            persistirDVV("Usuario");
        }

        public override IList<UsuarioBE> ListAll()
        {
            string SentenciaListar = string.Format("select * from usuario");
            IList<UsuarioBE> ListaUsuarios = new List<UsuarioBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    UsuarioBE UsuBE = new UsuarioBE();

                    CargarUsuario(UsuBE, fila);
                    ListaUsuarios.Add(UsuBE);

                }

            }
            return ListaUsuarios;
        }

        public void AsignarPermiso(UsuarioBE UsuBE, Permiso_ServicioBE permisoBE)
        {
            string sentenciaAsignarPermiso = string.Format("insert into UsuarioPermiso(usuarioID,permisoID,DVH)values('{0}','{1}','{2}')", UsuBE.ID, permisoBE.ID, UsuBE.dvh + permisoBE.dvh);
            this.ABM_Asistentes(sentenciaAsignarPermiso);
        }

        public void QuitarPermiso(UsuarioBE usuBE, Permiso_ServicioBE perBE)
        {
            try
            {
                string SentenciaBaja = string.Format("delete UsuarioPermiso where UsuarioID = '{0}' and PermisoID = '{1}'", usuBE.ID, perBE.ID);
                this.ABM_Asistentes(SentenciaBaja);
            }
            catch (Exception)
            {
            }
        }

        public void CargarUsuario(UsuarioBE usube, System.Data.DataRow Fila)
        {
            usube.ID = Convert.ToString(Fila["ID"]);
            usube.nombreUsuario = Convert.ToString(Fila["NombreUsuario"]);
            usube.clave = Convert.ToString(Fila["Clave"]);
            usube.fechaCreacion = Convert.ToDateTime(Fila["FechaCreacion"]);
            usube.fechaEliminacion = Convert.ToDateTime(Fila["FechaEliminacion"]);
            usube.dvh = Convert.ToString(Fila["DVH"]);
        }

        public override void Update(UsuarioBE BE)
        {
            string sentenciaModificar = string.Format("update usuario set nombreUsuario='{0}', dvh='{1}' where ID='{2}'", BE.nombreUsuario, BE.dvh, BE.ID);
            this.ABM_Asistentes(sentenciaModificar);
            //persistirDVV("Usuario");
        }

        public int ObtenerProximoID()
        {
            int resultado = 0;
            string SentenciaID = string.Format("select isnull(max(id),0) from Usuario");

            resultado = this.ObtenerID(SentenciaID);
            resultado = Convert.ToInt32(resultado) + 1;

            return resultado;
        }
    }
}


