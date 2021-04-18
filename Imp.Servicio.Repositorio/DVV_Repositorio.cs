using System.Collections.Generic;
using fw.ServiceManager.Repositories;
using Imp.ServicesManagerEntities;
using SQL.Provider;

namespace Imp.ServicesManager.Repositories
{
    public class DVV_Repositorio : ServiceManagerRepository<DVV_BE>
    {
        public DVV_Repositorio() : base(new DVVContexto())
        {
        }

        public override void Save(DVV_BE BE)
        {
            context.Save(BE);
        }

        public override void Delete(DVV_BE BE)
        {
            context.Delete(BE);
        }

        public override IList<DVV_BE> ListAll()
        {
            return context.ListAll();
        }

        public override void Update(DVV_BE BE)
        {
            context.Update(BE);
        }
    }
}