using System.Collections.Generic;
using fw.ServiceManager.Repositories;
using Imp.ServicesManagerEntities;
using SQL.Provider;

namespace Imp.ServicesManager.Repositories
{
    public class BitacoraUsuario_ServicioRepo : ServiceManagerRepository<BitacoraUsuario_ServicioBE>
    {
        public BitacoraUsuario_ServicioRepo() : base(new BitacoraUsuarioSQL())
        {
        }

        public override void Save(BitacoraUsuario_ServicioBE BE)
        {
            context.Save(BE);
        }

        public override void Delete(BitacoraUsuario_ServicioBE BE)
        {
            context.Delete(BE);
        }

        public override IList<BitacoraUsuario_ServicioBE> ListAll()
        {
            return context.ListAll();
        }

        public override void Update(BitacoraUsuario_ServicioBE BE)
        {
            context.Update(BE);
        }
    }
}