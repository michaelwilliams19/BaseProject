using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using fw.Interfaces;


namespace fw.Repositorio
{
    public abstract class Repositorio<T> : IABM<T> where T : IBaseEntity
    {
        protected IABM<T> _contexto;
        
        public Repositorio(IABM<T> contexto)
        {
            _contexto = contexto;
        }


        public abstract void Alta(T BE);
        public abstract void Baja(T BE);
        public abstract IList<T> Listar();
        public abstract void Modificar(T BE);
    }
}
