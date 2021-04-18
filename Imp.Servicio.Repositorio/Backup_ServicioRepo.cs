using System.Collections.Generic;
using fw.ServiceManager.Repositories;
using Imp.ServicesManagerEntities;
using SQL.Provider;

namespace Imp.ServicesManager.Repositories
{
    public class Backup_ServicioRepo : ServiceManagerRepository<Backup_ServicioBE>
    {
        BackupSQL contextoSQL = new BackupSQL();
        public Backup_ServicioRepo() :base(new BackupSQL())
        {
        }

        public override void Save(Backup_ServicioBE BE)
        {
            context.Save(BE);
        }

        public override void Delete(Backup_ServicioBE BE)
        {
            context.Delete(BE);
        }

        public override IList<Backup_ServicioBE> ListAll()
        {
            return context.ListAll();
        }

        public override void Update(Backup_ServicioBE BE)
        {
            context.Update(BE);
        }

        public void RealizarRestore(Backup_ServicioBE backupBE)
        {
            contextoSQL.RealizarRestore(backupBE);
        }
    }
}