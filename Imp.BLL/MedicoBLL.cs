using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.BLL;
using fw.BE;
using Imp.BE;
using fw.Repositorio;
using Imp.Repositorio;
using fw.Seguridad;
using fw.ServicioBE;
using Imp.ServicioBE;
using fw.Servicio.BLL;
using Imp.Servicio;


namespace Imp.BLL
{
    public class MedicoBLL : BLL<MedicoBE>
    {

        public MedicoBLL() : base(new MedicoRepositorio())
        { }


    }
}
