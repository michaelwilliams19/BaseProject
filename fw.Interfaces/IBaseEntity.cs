using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fw.Interfaces
{
    public interface IBaseEntity : Idvh
    {
        string ID { get; set; }
        DateTime fechaCreacion { get; set; }
        DateTime fechaEliminacion { get; set; }
    }
}
