using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;

namespace fw.ServicioBE
{
    public class ServicioBE : IBaseEntity 

    {

        public ServicioBE()
        {
            ID = Convert.ToString(Guid.NewGuid());
        }

        private string _id;
        public string ID
        {
            get
            {
                
                return _id;
            }


            set => _id = value;
        }

        private string _FechaCreacion;
        public string FechaCreacion {
            get
            {
                _FechaCreacion = Convert.ToString(DateTime.Now);
                 return _FechaCreacion;

            }
            

            set => _FechaCreacion = value; }


        private string _FechaEliminacion;
        public string FechaEliminacion { get => _FechaEliminacion; set => _FechaEliminacion = value; }

        private string _Nombre;
        public string Nombre { get => _Nombre; set => _Nombre = value; }

        private string _dvh;
        public string dvh
        {
            get { return _dvh; }
            set { _dvh = value; }
        }

       
    }
}
