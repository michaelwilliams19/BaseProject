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
    public class Backup_ServicioBLL : Servicio<Backup_ServicioBE>
    {
        Backup_ServicioRepo backupRepo = new Backup_ServicioRepo();

        public Backup_ServicioBLL() : base(new Backup_ServicioRepo())
        {


        }


        public void RealizarRestore(Backup_ServicioBE backupBE)
        {
            backupRepo.RealizarRestore(backupBE);
                       
        }


        


    }
}
