using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServiceManager.Repositories;
using Imp.ServicesManager.Repositories;
using fw.ServiceManagerEntities;
using Imp.ServicesManagerEntities;
using fw.ServiceManager.Services;
using Imp.Entities;


namespace Imp.ServicesManager
{
    public class Familia_ServicioBLL : Permiso_ServicioBLL
    {
        Permiso_ServicioRepo permisoRepositorio = new Permiso_ServicioRepo();
        public Familia_ServicioBLL() : base()
        {
        }

        public override void AgregarHijo(Permiso_ServicioBE familiaE, Permiso_ServicioBE permisoE)
        {
            try
            {
                if (recorrerLista(permisoE, familiaE) == false)
                {
                    if (recorrerLista(familiaE, permisoE) == false)
                    {
                        familiaE.listaHijos.Add(permisoE);
                        permisoRepositorio.AgregarHijoAFamilia(familiaE, permisoE);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public Boolean recorrerLista(Permiso_ServicioBE hijo, Permiso_ServicioBE familia)
        {
            Boolean permisoExistente = false;

            if (hijo.Nombre == familia.Nombre)
            {
                permisoExistente = true;
            }
            else
            {
                try
                {
                    foreach (Permiso_ServicioBE item in familia.listaHijos)
                    {
                        if (item.Nombre == hijo.Nombre)
                        {
                            permisoExistente = true;
                            break;
                        }
                        if (item.listaHijos.Count > 0)
                        {
                            permisoExistente = recorrerLista(hijo, item);
                            if (permisoExistente == true)
                            {
                                break;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
            return permisoExistente;
        }


        public override void EliminarHijo(Permiso_ServicioBE permisoE)
        {
            base.Delete(permisoE);
        }

        public void DesAsignarHijo(Permiso_ServicioBE familia, Permiso_ServicioBE permiso)
        {
            permisoRepositorio.EliminarHijoDeFamilia(familia, permiso);
        }

        public override IList<Permiso_ServicioBE> ObtenerHijos(Permiso_ServicioBE permisoE)
        {
            return permisoRepositorio.ObtenerHijos(permisoE);
        }

        public IList<Permiso_ServicioBE> listarPermisosXUsuario(UsuarioBE usuBE)
        {
            return permisoRepositorio.ListarPermisosXusuario(usuBE);
        }

        public IList<Permiso_ServicioBE> RetornarPermisosPermitidos(Permiso_ServicioBE PermisoAVerificar)
        {
            IList<Permiso_ServicioBE> ListaDePermisosPermitidos = new List<Permiso_ServicioBE>();

            foreach (Permiso_ServicioBE item in ListAll())
            {
                if (recorrerLista(PermisoAVerificar, item) == false)
                {
                    if (recorrerLista(item, PermisoAVerificar) == false)
                    {
                        ListaDePermisosPermitidos.Add(item);
                    }
                }
            }
            return ListaDePermisosPermitidos;
        }
    }
}