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

namespace Imp.Servicio
{
    public class Etiqueta_ServicioBLL : Servicio<Etiqueta_ServicioBE>
    {

        public Etiqueta_ServicioBLL() : base(new Etiqueta_ServicioRepo())
        { }

        Boolean existeEtiqueta=false;


        public void compararEtiquetas(Etiqueta_ServicioBE etiquetaBE)
        {
            existeEtiqueta = false;
            if (this.Listar().Count > 0)
            {
                foreach (Etiqueta_ServicioBE item in this.Listar())
                {
                    if (etiquetaBE.NombreEtiqueta == item.NombreEtiqueta)
                    {
                        existeEtiqueta = true;
                        
                    }

                }

            }

            if (existeEtiqueta == false)
            {
                base.Alta(etiquetaBE);
            }

        }


    }
}
