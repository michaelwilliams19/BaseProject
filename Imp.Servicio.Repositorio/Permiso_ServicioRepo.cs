using System.Collections.Generic;
using fw.ServiceManager.Repositories;
using Imp.ServicesManagerEntities;
using SQL.Provider;
using Imp.Entities;

namespace Imp.ServicesManager.Repositories
{
    public class Permiso_ServicioRepo : ServiceManagerRepository<Permiso_ServicioBE>
    {
        PermisoSQL perm = new PermisoSQL();

        public Permiso_ServicioRepo() : base(new PermisoSQL())
        { 
        }

        public override void Save(Permiso_ServicioBE BE)
        {
            context.Save(BE);
        }

        public override void Delete(Permiso_ServicioBE BE)
        {
            context.Delete(BE);
        }

        public override IList<Permiso_ServicioBE> ListAll()
        {
            return context.ListAll();
        }

        public override void Update(Permiso_ServicioBE BE)
        {
            context.Update(BE);
        }

        public void AgregarHijoAFamilia(Permiso_ServicioBE familia, Permiso_ServicioBE permiso)
        {           
            perm.AgregarHijoBD(familia, permiso);
        }

        public void EliminarHijoDeFamilia(Permiso_ServicioBE familia, Permiso_ServicioBE permiso)
        {
            perm.EliminarHijo(familia, permiso);
        }

        public IList<Permiso_ServicioBE> ObtenerHijos(Permiso_ServicioBE p)
        {
            return perm.ObtenerHijosBD(p);
        }

        public IList<Permiso_ServicioBE> ListarPermisosXusuario(UsuarioBE usuBE)
        {
            return perm.ListarPermisosXUsuario(usuBE);
        }
    }
}
