using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using fw.Interfaces;

namespace Imp.BE
{
    public class EspecialidadBE : fw.BE.BE
    {
        public EspecialidadBE()
        {
            ID = Convert.ToString(Guid.NewGuid());
        }

    }
}
