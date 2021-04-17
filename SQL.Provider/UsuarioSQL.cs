
using System;
using System.Collections.Generic;
using Imp.BE;
using Imp.ServicioBE;

namespace SQL.Provider
{
    public class UsuarioSQL : ContextoSQL<UsuarioBE>
    {

        public UsuarioSQL()
        { }


        public override void Alta(UsuarioBE BE)
        {


            string SentenciaAlta = string.Format("insert into usuario(id,nombre,nombreUsuario,clave,fechacreacion, fechaeliminacion,DVH) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Convert.ToString(ObtenerProximoID()), BE.Nombre, BE.NombreUsuario, BE.Clave, BE.FechaCreacion, BE.FechaEliminacion, BE.dvh);
            this.ABM_Asistentes(SentenciaAlta);
            persistirDVV("Usuario");

        }

        public override void Baja(UsuarioBE BE)
        {
            string SentenciaBaja = string.Format("Delete from usuario where id='{0}'", BE.ID);
            this.ABM_Asistentes(SentenciaBaja);
            persistirDVV("Usuario");
        }

        public override IList<UsuarioBE> Listar()
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
            usube.Nombre = Convert.ToString(Fila["Nombre"]);
            usube.NombreUsuario = Convert.ToString(Fila["NombreUsuario"]);
            usube.Clave = Convert.ToString(Fila["Clave"]);
            usube.FechaCreacion = Convert.ToString(Fila["FechaCreacion"]);
            usube.FechaEliminacion = Convert.ToString(Fila["FechaEliminacion"]);
            usube.dvh = Convert.ToString(Fila["DVH"]);



        }



        public override void Modificar(UsuarioBE BE)
        {
            string sentenciaModificar = string.Format("update usuario set nombre='{0}' , nombreUsuario='{1}', dvh='{2}' where ID='{3}'", BE.Nombre, BE.NombreUsuario, BE.dvh, BE.ID);
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


        public void AsignarEspecialidad(UsuarioBE UsuBE, EspecialidadBE especBE)
        {
            string sentenciaAsignarEspec = string.Format("insert into UsuarioEspecialidad(usuarioID,EspecialidadID,DVH)values('{0}','{1}','{2}')", UsuBE.ID, especBE.ID, UsuBE.dvh + especBE.dvh);
            this.ABM_Asistentes(sentenciaAsignarEspec);
        }


        public List<UsuarioBE> ListarUsuariosXEspecialidad(EspecialidadBE especBE)
        {
            string SentenciaListar = string.Format("select * from usuario inner join UsuarioEspecialidad on id=usuarioID and EspecialidadID='{0}'", especBE.ID);

            List<UsuarioBE> ListaDeUsuarios = new List<UsuarioBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {


                    UsuarioBE usuarioE = new UsuarioBE();

                    CargarUsuario(usuarioE, fila);
                    ListaDeUsuarios.Add(usuarioE);
                }

            }
            return ListaDeUsuarios;
        }
        public List<UsuarioBE> ListarMedicos()
        {
            string SentenciaListar = string.Format("select * from usuario inner join UsuarioEspecialidad on id= usuarioID");

            List<UsuarioBE> ListaDeUsuarios = new List<UsuarioBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    UsuarioBE usuarioE = new UsuarioBE();

                    CargarUsuario(usuarioE, fila);
                    ListaDeUsuarios.Add(usuarioE);
                }

            }
            return ListaDeUsuarios;
        }




    }


}



