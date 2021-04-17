using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using SQL.Provider;

namespace fw.Servicio.Repositorio
{
    public abstract class ServicioRepositorio<T> : IABM<T> where T : IBaseEntity
    {
        protected IABM<T> _Contexto;

        public ServicioRepositorio(IABM<T> contexto)
        {
            _Contexto = contexto;
        }

        public abstract void Alta(T BE);
        public abstract void Baja(T BE);
        public abstract IList<T> Listar();
        public abstract void Modificar(T BE);

    }
}
