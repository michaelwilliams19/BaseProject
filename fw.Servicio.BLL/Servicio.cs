using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.Servicio.Repositorio;


namespace fw.Servicio.BLL
{
    public abstract class Servicio<T> : IABM<T> where T : IBaseEntity
    {
        IABM<T> _RepositoryServicio;


        public Servicio(IABM<T> RepositoryServicio) 
        {
            _RepositoryServicio = RepositoryServicio;

        }

        public void Alta(T BE)
        {
            
            _RepositoryServicio.Alta(BE);
        }

        public void Baja(T BE)
        {
            _RepositoryServicio.Baja(BE);
        }

        public IList<T> Listar()
        {
           return _RepositoryServicio.Listar();
        }

        public void Modificar(T BE)
        {
            _RepositoryServicio.Modificar(BE);
        }
    }
}
