using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServicioBE;
using fw.Servicio.BLL;
using Imp.ServicioBE;
using fw.Interfaces;
using Imp.Servicio.Repositorio;
using fw.Seguridad;
using System.Reflection;
using SQL.Provider;
using fw.BE;
using Imp.BE;

namespace Imp.Servicio
{
    public class DVV_BLL : Servicio<DVV_BE>
    {
        public DVV_BLL() : base(new DVV_Repositorio())
        { }

        public void GenerarDVV()
        {
            bool ExisteDVV = false;
            string digito = string.Empty;
            UsuarioSQL usuSQL = new UsuarioSQL();

            foreach (DVV_BE item in Listar())
            {
                if (item.Nombre == "Usuario")
                {
                    ExisteDVV = true;
                    break;
                }
            }
            if (!ExisteDVV)
            {              
                foreach (UsuarioBE item in usuSQL.Listar())
                {
                    digito += GetDVH(item);
                }
                DVV_BE dvv = new DVV_BE();
                dvv.Nombre = "Usuario";
                dvv.digitoVerificador = digito;
                this.Alta(dvv);
            }
            else
            {                
                DVV_BE dv = new DVV_BE();
                foreach (UsuarioBE item in usuSQL.Listar())
                {
                    digito += GetDVH(item);
                }
                
                dv.Nombre = "Usuario";                
                dv.digitoVerificador = digito;
                this.Modificar(dv);               
            }
        }


        public static string GetDVH(IBaseEntity entity)
        {
            Encriptacion miEncriptador = new Encriptacion();
            string dvh = string.Empty;
            Type t = entity.GetType();

            var props = t.GetProperties();

            foreach (var p in props)
            {
                if ((p.Name != "DVH") || (p.Name !="dvh"))
                {
                    dvh += p.GetValue(entity);
                }

            }

            
            dvh = miEncriptador.Encriptar(dvh);

            return dvh;
        }

        public void calcularDVVActual()
        {

            string digito2 = string.Empty;

            UsuarioSQL usuSQL = new UsuarioSQL();

            foreach (UsuarioBE item in usuSQL.Listar())
            {
                digito2 += GetDVH(item);
            }

            foreach (DVV_BE item in Listar())
            {
                if (item.Nombre == "Usuario")
                {
                    if (digito2 != item.digitoVerificador)
                    {
                        //throw new DVVExcepcion();
                    }
                }

            }

        }

    }
}
