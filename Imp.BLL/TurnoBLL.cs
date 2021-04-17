using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.BLL;
using fw.BE;
using Imp.BE;
using fw.Repositorio;
using Imp.Repositorio;
using fw.Seguridad;
using fw.ServicioBE;
using Imp.ServicioBE;
using fw.Servicio.BLL;
using Imp.Servicio;


namespace Imp.BLL
{
    public class TurnoBLL : BLL<TurnoBE>
    {

        public TurnoBLL() : base(new TurnoRepositorio())
        { }


        public List<DateTime> listarTurnosDisponibles(List<DateTime> listaFechas)
        {
            IList<TurnoBE> listaTurnos = new List<TurnoBE>();
            listaTurnos = this.Listar();

            List<DateTime> listaFechasModificada = new List<DateTime>();
            

            foreach (DateTime item in listaFechas)
            {
                foreach(TurnoBE itemTurno in listaTurnos)
                {
                    if (item == Convert.ToDateTime(itemTurno.fechaTurno))
                    {
                        break;
                        
                    }
                    else 
                    {
                        listaFechasModificada.Add(item);
                        

                    }
                }
            }

            
            return listaFechasModificada; 
        }

    }
}
