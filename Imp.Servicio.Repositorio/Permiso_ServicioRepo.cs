using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Servicio.Repositorio;
using fw.ServicioBE;
using Imp.ServicioBE;
using SQL.Provider;
using Imp.BE;


namespace Imp.Servicio.Repositorio
{
    public class Permiso_ServicioRepo : ServicioRepositorio<Permiso_ServicioBE>
    {
        PermisoSQL perm = new PermisoSQL();

        public Permiso_ServicioRepo() : base(new PermisoSQL())
        { }

        public override void Alta(Permiso_ServicioBE BE)
        {
            _Contexto.Alta(BE);
        }

        public override void Baja(Permiso_ServicioBE BE)
        {
            _Contexto.Baja(BE);
        }

        public override IList<Permiso_ServicioBE> Listar()
        {
            return _Contexto.Listar();
        }

        public override void Modificar(Permiso_ServicioBE BE)
        {
            _Contexto.Modificar(BE);
        }




        public void AgregarHijoAFamilia(Permiso_ServicioBE familia, Permiso_ServicioBE permiso)
        {
            
            perm.AgregarHijoBD(familia, permiso);
        }

        public void EliminarHijoDeFamilia(Permiso_ServicioBE familia, Permiso_ServicioBE permiso)
        {
            perm.EliminarHijo(familia, permiso);
        }


        public IList<Permiso_ServicioBE> ObtenerHijos(Permiso_ServicioBE p)
        {

            return perm.ObtenerHijosBD(p);
        }

        public IList<Permiso_ServicioBE> ListarPermisosXusuario(UsuarioBE usuBE)
        {
            return perm.ListarPermisosXUsuario(usuBE);

        }





    }
}
