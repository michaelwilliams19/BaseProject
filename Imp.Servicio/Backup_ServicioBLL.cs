using fw.ServiceManager.Services;
using Imp.ServicesManagerEntities;
using Imp.ServicesManager.Repositories;

namespace Imp.ServicesManager
{
    public class Backup_ServicioBLL : ServiceManager<Backup_ServicioBE>
    {
        Backup_ServicioRepo backupRepo = new Backup_ServicioRepo();

        public Backup_ServicioBLL() : base(new Backup_ServicioRepo())
        {
        }

        public void RealizarRestore(Backup_ServicioBE backupBE)
        {
            backupRepo.RealizarRestore(backupBE);
        }
    }
}
