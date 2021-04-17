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
    public class PermisoSQL : ContextoSQL<Permiso_ServicioBE>
    {
        public override void Alta(Permiso_ServicioBE BE)
        {
            string SentenciaAlta = string.Format("insert into permiso(id,nombre,DVH) values('{0}','{1}','{2}')", BE.ID, BE.Nombre, BE.dvh);
            this.ABM_Asistentes(SentenciaAlta);
        }

        public override void Baja(Permiso_ServicioBE BE)
        {
            string SentenciaBaja = string.Format("Delete from permiso where id='{0}'", BE.ID);
            this.ABM_Asistentes(SentenciaBaja);
        }

        public override IList<Permiso_ServicioBE> Listar()
        {
            string SentenciaListar = string.Format("select * from permiso");
            IList<Permiso_ServicioBE> ListaDePermisos = new List<Permiso_ServicioBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    

                    Permiso_ServicioBE PerBE = new Permiso_ServicioBE();

                    CargarPermisos(PerBE, fila);
                    ListaDePermisos.Add(PerBE);
                }

            }
            return ListaDePermisos;
        }

        public void CargarPermisos(Permiso_ServicioBE perbe, System.Data.DataRow Fila)
        {
            perbe.ID = Convert.ToString(Fila["ID"]);
            perbe.Nombre = Convert.ToString(Fila["Nombre"]);
            perbe.FechaCreacion = Convert.ToString(Fila["fechacreacion"]);
            perbe.FechaEliminacion = Convert.ToString(Fila["fechaeliminacion"]);
            perbe.dvh = Convert.ToString(Fila["DVH"]);
            perbe.listaHijos = ObtenerHijosBD(perbe);

        }


        public override void Modificar(Permiso_ServicioBE BE)
        {
            string SentenciaModificar = string.Format("update Permiso set Nombre= '{0}' where id= '{1}';", BE.Nombre, BE.ID);
            this.ABM_Asistentes(SentenciaModificar);
        }



        public List<Permiso_ServicioBE> ObtenerHijosBD(Permiso_ServicioBE p)
        {
            string SentenciaListar = string.Format("SELECT * FROM Permiso INNER JOIN PermisoFamilia ON Id = PermisoID and FamiliaID = '{0}'", p.ID);
            List<Permiso_ServicioBE> ListaPermisos = new List<Permiso_ServicioBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    Permiso_ServicioBE PermisoBE = new Permiso_ServicioBE();

                    CargarPermisos(PermisoBE, fila);
                    ListaPermisos.Add(PermisoBE);

                }

            }
            return ListaPermisos;

        }


        public void AgregarHijoBD(Permiso_ServicioBE familia, Permiso_ServicioBE permiso)
        {
            string SentenciaAlta = string.Format("insert into PermisoFamilia(FamiliaID, PermisoID) values('{0}','{1}')", familia.ID, permiso.ID);
            this.ABM_Asistentes(SentenciaAlta);
        }

        public void EliminarHijo(Permiso_ServicioBE permisoBE, Permiso_ServicioBE perm2)
        {
            string sentenciaBajaHijo = string.Format("delete from permisoFamilia where familiaID='{0}' and permisoID='{1}'", permisoBE.ID, perm2.ID);
            this.ABM_Asistentes(sentenciaBajaHijo);
        }


        public IList<Permiso_ServicioBE> ListarPermisosXUsuario(UsuarioBE usuBE)
        {
            string SentenciaListar = string.Format("select * from permiso inner join UsuarioPermiso on id= permisoID and usuarioID='{0}'", usuBE.ID);

            IList<Permiso_ServicioBE> ListaDePermisos = new List<Permiso_ServicioBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    

                    Permiso_ServicioBE PerBE = new Permiso_ServicioBE();

                    CargarPermisos(PerBE, fila);
                    ListaDePermisos.Add(PerBE);
                }

            }
            return ListaDePermisos;




        }
    }
}
