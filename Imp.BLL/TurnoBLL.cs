using fw.Services;
using Imp.Entities;
using Imp.Repositories;

namespace Imp.Services
{
    public class TurnoBLL : Service<TurnoBE>
    {
        public TurnoBLL() : base(new TurnoRepositorio())
        {
        }
    }
}
