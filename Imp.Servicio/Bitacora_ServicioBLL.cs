using fw.ServiceManager.Services;
using Imp.ServicesManagerEntities;
using Imp.ServicesManager.Repositories;

namespace Imp.ServicesManager
{
    public class Bitacora_ServicioBLL : ServiceManager<BitacoraBE>
    {
        public Bitacora_ServicioBLL() : base(new Bitacora_ServicioRepo())
        {
        }
    }
}