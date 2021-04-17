using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServicioBE;
using fw.Servicio.Repositorio;
using Imp.ServicioBE;
using SQL.Provider;
using fw.Interfaces;

namespace Imp.Servicio.Repositorio
{
    public class Backup_ServicioRepo : ServicioRepositorio<Backup_ServicioBE>
    {


        BackupSQL contextoSQL = new BackupSQL();

        public Backup_ServicioRepo() :base(new BackupSQL())
        {


        }

        public override void Alta(Backup_ServicioBE BE)
        {
            _Contexto.Alta(BE);
        }

        public override void Baja(Backup_ServicioBE BE)
        {
            _Contexto.Baja(BE);
        }

        public override IList<Backup_ServicioBE> Listar()
        {
            return _Contexto.Listar();
        }

        public override void Modificar(Backup_ServicioBE BE)
        {
            _Contexto.Modificar(BE);
        }

        public void RealizarRestore(Backup_ServicioBE backupBE)
        {
            contextoSQL.RealizarRestore(backupBE);       

            

            
        }


    }
}
