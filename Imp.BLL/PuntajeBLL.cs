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
    public class PuntajeBLL : BLL<PuntajeBE> 
    {
        UsuarioBLL usuBLL = new UsuarioBLL();

        public PuntajeBLL() : base(new PuntajeRepositorio())
        { }
        

        public List<PuntajeBE> ListarPuntajesXUsuario(UsuarioBE usuBE)
        {
            List<PuntajeBE> listaFiltrada = new List<PuntajeBE>();

            foreach (PuntajeBE item in this.Listar())
            {
                if (item.idForaneo == usuBE.ID)
                {
                    listaFiltrada.Add(item);
                }

            }
            return listaFiltrada;
        }



        public List<UsuarioBE> listarMedicosConMayorPuntuacionXEspecialidad(EspecialidadBE especBE)
        {
            int promedioPuntajes = 0;
            int promedioTotal=0;
            int countPuntajes=0;

            int promedioAnterior = 0;
            PuntajeBE nuevoPuntaje = new PuntajeBE();
            List<PuntajeBE> listaPuntajesFiltrados = new List<PuntajeBE>();
            List<UsuarioBE> listaMedicos = new List<UsuarioBE>();

            UsuarioBE medicoBEMaximo = new UsuarioBE();

            foreach (var itemUsuario in usuBLL.listarMedicosXEspecialidad(especBE))
            {
                promedioPuntajes = 0;
                promedioTotal = 0;
                countPuntajes = 0;                                

                foreach (PuntajeBE itemPuntaje in ListarPuntajesXUsuario(itemUsuario))
                {
                    countPuntajes += 1;
                    promedioPuntajes = promedioPuntajes + itemPuntaje.puntaje;
                    promedioTotal = promedioPuntajes / countPuntajes;

                    if (promedioTotal > promedioAnterior)
                    {
                        promedioAnterior = promedioTotal;
                        medicoBEMaximo = itemUsuario;                       
                    }
                    
                    //nuevoPuntaje.puntaje = promedioTotal;
                    //nuevoPuntaje.idForaneo = itemUsuario.ID;

                                        
                }
                listaPuntajesFiltrados.Add(nuevoPuntaje);
            }
            listaMedicos.Add(medicoBEMaximo);

            return listaMedicos;
        }


        public List<PuntajeBE> ListaPromedioDepuntajes(UsuarioBE usuBE)
        {
            int promedioPuntajes = 0;
            int promedioTotal = 0;
            int countPuntajes = 0;


            PuntajeBE nuevoPuntaje = new PuntajeBE();
            List<PuntajeBE> listaPuntajes = new List<PuntajeBE>();


            foreach (PuntajeBE item in this.ListarPuntajesXUsuario(usuBE))
            {
                countPuntajes += 1;
                promedioPuntajes = promedioPuntajes + item.puntaje;
                promedioTotal = promedioPuntajes / countPuntajes;

                nuevoPuntaje.puntaje = promedioTotal;
                nuevoPuntaje.idForaneo = usuBE.ID;

                

                promedioPuntajes = 0;
                promedioTotal = 0;
                countPuntajes = 0;
            }
            listaPuntajes.Add(nuevoPuntaje);
            return listaPuntajes;          

        }

        




        

        
        
        
    }
}
