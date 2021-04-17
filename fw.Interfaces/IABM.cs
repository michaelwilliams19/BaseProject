using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fw.Interfaces
{
   public interface IABM<T> where T : IBaseEntity
    {        
            void Alta(T BE);
            void Baja(T BE);
            void Modificar(T BE);
            IList<T> Listar();        

    }
}
