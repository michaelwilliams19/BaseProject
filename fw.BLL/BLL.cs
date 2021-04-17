using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.BE;
using Imp.Validator;


namespace fw.BLL
{
    public abstract class BLL<T> : IABM<T> where T : IBaseEntity
    {

        
        IABM<T> Repository;

        public BLL(IABM<T> _Repository)
        {
            Repository = _Repository;
        }
        

        public void Alta(T BE)
        {            
            BE.Validar<T>();
            Repository.Alta(BE);            
        }

        public void Baja(T BE)
        {
         
            Repository.Baja(BE);
        }

        public IList<T> Listar()
        {
            return Repository.Listar();
        }

        public void Modificar(T BE)
        {
            BE.Validar<T>();
            Repository.Modificar(BE);                                       
        }
    }
}
