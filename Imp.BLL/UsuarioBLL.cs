using System;
using System.Collections.Generic;
using fw.Services;
using Imp.Entities;
using Imp.Repositories;
using fw.Security;
using Imp.ServicesManagerEntities;
using Imp.ServicesManager;

namespace Imp.Services
{
    public class UsuarioBLL : Service<UsuarioBE>
    {
        Encriptacion encriptador = new Encriptacion();
        UsuarioRepositorio UsuRepositorio = new UsuarioRepositorio();
        BitacoraUsuario_ServicioBLL BitacoraUsuarioBLL = new BitacoraUsuario_ServicioBLL();

        public UsuarioBLL() : base(new UsuarioRepositorio())
        {
        }

        public override void Save(UsuarioBE BE)
        {
            BE.clave = encriptador.Encriptar(BE.clave);
            base.Save(BE);
            BitacoraUsuarioBLL.RegistrarEnBitacora(Singleton.Instancia.DevolverUsuarioActivo(), BE);
        }

        public override void Update(UsuarioBE BE)
        {
            BE.clave = encriptador.Encriptar(BE.clave);
            base.Update(BE);
        }

        public int ObtenerID()
        {
            return UsuRepositorio.ObtenerID();
        }

        public UsuarioBE Login(UsuarioBE UsuBE)
        {
            Boolean usuEncontrado = false;

            foreach (UsuarioBE UsuarioE in base.ListAll())
            {

                if (UsuBE.nombreUsuario == UsuarioE.nombreUsuario)
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
    }
}