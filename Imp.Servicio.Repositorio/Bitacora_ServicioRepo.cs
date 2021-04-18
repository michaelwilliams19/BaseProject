using System.Collections.Generic;
using fw.ServiceManager.Repositories;
using Imp.ServicesManagerEntities;
using SQL.Provider;


namespace Imp.ServicesManager.Repositories
{
    public class Bitacora_ServicioRepo : ServiceManagerRepository<BitacoraBE>
    {
        public Bitacora_ServicioRepo() : base(new BitacoraEventosSQL())
        {
        }

        public override void Save(BitacoraBE BE)
        {
            context.Save(BE);
        }

        public override void Delete(BitacoraBE BE)
        {
            context.Delete(BE);
        }

        public override IList<BitacoraBE> ListAll()
        {
            return context.ListAll();
        }

        public override void Update(BitacoraBE BE)
        {
            context.Update(BE);
        }
    }
}