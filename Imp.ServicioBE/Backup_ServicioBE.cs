using System;
using System.Collections.Generic;
using System.Linq;
namespace Imp.ServicesManagerEntities
{
    public class Backup_ServicioBE : fw.ServiceManagerEntities.ServiceManagerEntity
    {
        public string NombreBackup { get; set; }
        public string Ruta { get; set; }
    }
}