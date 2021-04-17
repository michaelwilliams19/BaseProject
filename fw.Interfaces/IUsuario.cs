using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fw.Interfaces
{
    public interface IUsuario : IBaseEntity
    {

        

        string NombreUsuario { get; set; } 

        string Clave { get; set; }

       


        



    }
}
