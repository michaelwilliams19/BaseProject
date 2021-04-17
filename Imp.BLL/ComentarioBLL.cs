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
    public class ComentarioBLL : BLL<ComentarioBE>
    {
        public ComentarioBLL() : base(new ComentarioRepositorio())
        { }


        public List<ComentarioBE> ListarComentariosXUsuario(UsuarioBE usuBE)
        {
            List<ComentarioBE> listaFiltrada = new List<ComentarioBE>();

            foreach (ComentarioBE item in this.Listar())
            {
                if (item.idForaneo == usuBE.ID)
                {
                    listaFiltrada.Add(item);
                }

            }
            return listaFiltrada;
        }

    }
}
