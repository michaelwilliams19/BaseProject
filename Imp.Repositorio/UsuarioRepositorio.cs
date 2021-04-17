using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using Imp.BE;
using fw.Repositorio;
using SQL.Provider;
using Imp.ServicioBE;

namespace Imp.Repositorio
{
    public class UsuarioRepositorio : Repositorio<UsuarioBE>
    {
        UsuarioSQL usuContexto = new UsuarioSQL();

        public UsuarioRepositorio() : base(new UsuarioSQL())
        {
        }


        public override void Alta(UsuarioBE BE)
        {
            _contexto.Alta(BE);
        }

        public override void Baja(UsuarioBE BE)
        {
            _contexto.Baja(BE);
        }

        public override IList<UsuarioBE> Listar()
        {
            return _contexto.Listar();
        }

        public override void Modificar(UsuarioBE BE)
        {
            _contexto.Modificar(BE);
        }


        public void asignarPermisos(UsuarioBE BE, Permiso_ServicioBE permiso)
        {
            usuContexto.AsignarPermiso(BE, permiso);
        }

        public void QuitarPermiso(UsuarioBE usuBE, Permiso_ServicioBE perBE)
        {
            usuContexto.QuitarPermiso(usuBE, perBE);
        }


        public void asignarEspecialidad(UsuarioBE usuBE, EspecialidadBE especBE)
        {
            usuContexto.AsignarEspecialidad(usuBE, especBE);
        }

        public List<UsuarioBE> listarMedicosXEspecialidad(EspecialidadBE especBE)
        {
            return usuContexto.ListarUsuariosXEspecialidad(especBE);
        }

        public List<UsuarioBE> listarMedicos()
        {
            return usuContexto.ListarMedicos();
        }


        public int ObtenerID()
        {
            UsuarioSQL sql1 = new UsuarioSQL();

            return sql1.ObtenerProximoID();

        }


        

    }
}
