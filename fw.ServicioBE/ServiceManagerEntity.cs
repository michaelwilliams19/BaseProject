using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;

namespace fw.ServiceManagerEntities
{
    public class ServiceManagerEntity : IBaseEntity
    {
        public string ID { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaEliminacion { get; set; }
        public string nombre { get; set; }
        public string dvh { get; set; }
    }
}
