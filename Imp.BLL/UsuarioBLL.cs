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
    public class UsuarioBLL : BLL<UsuarioBE>

    {
        UsuarioRepositorio UsuRepositorio = new UsuarioRepositorio();
        Encriptacion encriptador = new Encriptacion();

        BitacoraUsuario_ServicioBLL BitacoraUsuarioBLL = new BitacoraUsuario_ServicioBLL();




        public UsuarioBLL() : base(new UsuarioRepositorio())
        {

        }

        
        public new void Alta(UsuarioBE BE)
        {
            
            
           BE.Clave= encriptador.Encriptar(BE.Clave);
           base.Alta(BE);

            
            BitacoraUsuarioBLL.RegistrarEnBitacora(Singleton.Instancia.DevolverUsuarioActivo(), BE);

        }

        public int ObtenerID()
        {
            return UsuRepositorio.ObtenerID();
        }



        public new void Modificar(UsuarioBE BE)
        {

            BE.Clave = encriptador.Encriptar(BE.Clave);
            base.Modificar(BE);                  
                       
                        
        }





        public UsuarioBE Login(UsuarioBE UsuBE)
        {
            Boolean usuEncontrado = false;


            foreach (UsuarioBE UsuarioE in base.Listar())
            {
            
                if (UsuBE.NombreUsuario == UsuarioE.NombreUsuario)
                {                   
                    if (encriptador.Comparar(UsuBE, UsuarioE) != false)
                    {
                        UsuBE = UsuarioE;
                        usuEncontrado = true;
                        Singleton.Instancia.RelacionarUsuario(UsuBE);
                    }
                    else
                    {
                        UsuBE = null;
                        break;
                    }
                }               

            }
            if (usuEncontrado == false)
            {
                UsuBE = null;
            }

            return UsuBE;
        }





        public void CerrarSesion()
        {
            Singleton.Instancia.EliminarInstancia();
        }



        public void asignarPermisos(UsuarioBE usuBE, Permiso_ServicioBE permisoBE)
        {
            UsuRepositorio.asignarPermisos(usuBE, permisoBE);
        }

        public void quitarPermiso(UsuarioBE usuBE, Permiso_ServicioBE perBE)
        {
            UsuRepositorio.QuitarPermiso(usuBE, perBE);
        }


        public void asignarEspecialidad(UsuarioBE usuBE, EspecialidadBE especBE)
        {
            UsuRepositorio.asignarEspecialidad(usuBE, especBE);

        }

        public List<UsuarioBE> listarMedicosXEspecialidad(EspecialidadBE especBE)
        {
            return UsuRepositorio.listarMedicosXEspecialidad(especBE);
        }

        public List<UsuarioBE> listarMedicos()
        {
             return UsuRepositorio.listarMedicos();
        }


        
       



    }
}
