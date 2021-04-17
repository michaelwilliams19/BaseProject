using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;
using fw.Servicio.BLL;
using Imp.Servicio.Repositorio;
using fw.ServicioBE;
using Imp.ServicioBE;
using fw.Seguridad;

namespace Imp.Servicio
{
    public class Idioma_ServicioBLL : Servicio<Idioma_ServicioBE>
    {
                
        public Idioma_ServicioBLL() : base(new Idioma_ServicioRepo())
        { }
        
        public static List<IObserver> listaForms = new List<IObserver>();
               

        public void agregarObserver(IObserver observ)
        {            
            listaForms.Add(observ);
        }

        public void eliminarObserver(IObserver observ)
        {
            listaForms.Remove(observ);
        }

        public List<IObserver> devolverObservers()
        {
            return listaForms;
        }



        public void cambiarIdioma(Idioma_ServicioBE idi)
        {
            SingletonIdioma.InstanciaIdioma.relacionarIdioma(idi);

            notificarGrupo();
        }





        public void notificarGrupo()
        {
            foreach (var item in listaForms)
            {
                item.Notificar();
            }


        }


        




    }
}
