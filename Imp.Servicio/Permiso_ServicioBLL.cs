using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.Servicio.BLL;
using Imp.Servicio.Repositorio;
using fw.ServicioBE;
using Imp.ServicioBE;

namespace Imp.Servicio
{
    public class Permiso_ServicioBLL : Servicio<Permiso_ServicioBE>
    {      
        public Permiso_ServicioBLL() : base(new Permiso_ServicioRepo())
        { }


       

        public virtual void AgregarHijo(Permiso_ServicioBE familiaE,Permiso_ServicioBE permisoE)
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
