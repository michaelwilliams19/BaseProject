using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Entities;
using Imp.Entities;
using fw.Repositories;
using SQL.Provider;
using Imp.ServicesManagerEntities;

namespace Imp.Repositories
{
    public class UsuarioRepositorio : Repository<UsuarioBE>
    {
        UsuarioSQL usuContexto = new UsuarioSQL();

        public UsuarioRepositorio() : base(new UsuarioSQL())
        {
        }


        public override void Save(UsuarioBE BE)
        {
            context.Save(BE);
        }

        public override void Delete(UsuarioBE BE)
        {
            context.Delete(BE);
        }

        public override IList<UsuarioBE> ListAll()
        {
            return context.ListAll();
        }

        public override void Update(UsuarioBE BE)
        {
            context.Update(BE);
        }


        public void asignarPermisos(UsuarioBE BE, Permiso_ServicioBE permiso)
        {
            usuContexto.AsignarPermiso(BE, permiso);
        }

        public void QuitarPermiso(UsuarioBE usuBE, Permiso_ServicioBE perBE)
        {
            usuContexto.QuitarPermiso(usuBE, perBE);
        }

        public int ObtenerID()
        {
            UsuarioSQL sql1 = new UsuarioSQL();
            return sql1.ObtenerProximoID();
        }
    }
}
