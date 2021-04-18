using System.Collections.Generic;
using Imp.Entities;
using fw.Repositories;
using SQL.Provider;

namespace Imp.Repositories
{
    public class TurnoRepositorio : Repository<TurnoBE>
    {
        public TurnoRepositorio() : base(new TurnoContexto())
        { }

        public override void Save(TurnoBE BE)
        {
            context.Save(BE);
        }

        public override void Delete(TurnoBE BE)
        {
            context.Delete(BE);
        }

        public override IList<TurnoBE> ListAll()
        {
            return context.ListAll();
        }

        public override void Update(TurnoBE BE)
        {
            context.Update(BE);
        }
    }
}
