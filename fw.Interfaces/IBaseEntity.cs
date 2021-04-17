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

        string FechaCreacion { get; set; }

        string FechaEliminacion { get; set; }

        string Nombre { get; set; }


    }
}
