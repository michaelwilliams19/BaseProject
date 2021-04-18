using System;
using System.Collections.Generic;
using fw.ServiceManager.Services;
using Imp.ServicesManager.Repositories;
using Imp.ServicesManagerEntities;

namespace Imp.ServicesManager
{
    public class Permiso_ServicioBLL : ServiceManager<Permiso_ServicioBE>
    {
        public Permiso_ServicioBLL() : base(new Permiso_ServicioRepo())
        { }

        public virtual void AgregarHijo(Permiso_ServicioBE familiaE, Permiso_ServicioBE permisoE)
        {
            throw new NotImplementedException();
        }

        public virtual void EliminarHijo(Permiso_ServicioBE permisoE)
        {
            throw new NotImplementedException();
        }

        public virtual IList<Permiso_ServicioBE> ObtenerHijos(Permiso_ServicioBE permisoE)
        {
            throw new NotImplementedException();
        }
    }
}
