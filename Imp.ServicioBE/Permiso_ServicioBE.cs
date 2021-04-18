using System.Collections.Generic;

namespace Imp.ServicesManagerEntities
{
    public class Permiso_ServicioBE : fw.ServiceManagerEntities.ServiceManagerEntity
    {
        //public static List<PermisoBE> listaHijos = new List<PermisoBE>();
        public string Nombre { get; set; }        
        public List<Permiso_ServicioBE> listaHijos { get; set; }
    }
}
