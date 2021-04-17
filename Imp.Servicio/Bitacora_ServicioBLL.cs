using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServicioBE;
using fw.Servicio.BLL;
using Imp.ServicioBE;
using fw.Interfaces;
using Imp.Servicio.Repositorio;

namespace Imp.Servicio
{
    public class Bitacora_ServicioBLL : Servicio<BitacoraBE>
    {

        public Bitacora_ServicioBLL() : base(new Bitacora_ServicioRepo())
        { }



    }
}
