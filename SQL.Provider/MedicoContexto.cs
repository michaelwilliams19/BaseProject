using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imp.BE;
using Imp.ServicioBE;


namespace SQL.Provider
{
    public class MedicoContexto : ContextoSQL<MedicoBE>
    {
        public override void Alta(MedicoBE BE)
        {
            throw new NotImplementedException();
        }

        public override void Baja(MedicoBE BE)
        {
            throw new NotImplementedException();
        }

        public override IList<MedicoBE> Listar()
        {
            throw new NotImplementedException();
        }

        public override void Modificar(MedicoBE BE)
        {
            throw new NotImplementedException();
        }
    }
}
