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
    public class EspecialidadBLL : BLL<EspecialidadBE>
    {
        public EspecialidadBLL() : base(new EspecialidadRepositorio())
        { }



        public List<EspecialidadBE> listarXEspecialidad(EspecialidadBE especBE)
        {
            List<EspecialidadBE> listaEspecFiltrada = new List<EspecialidadBE>();

            foreach (EspecialidadBE item in this.Listar())
            {
                if (item.Nombre == especBE.Nombre)
                {
                    listaEspecFiltrada.Add(item);
                }
            }
            return listaEspecFiltrada;
        }

    }
}
