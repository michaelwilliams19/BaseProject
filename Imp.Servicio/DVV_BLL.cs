using System;
using fw.ServiceManager.Services;
using Imp.ServicesManagerEntities;
using fw.Interfaces;
using Imp.ServicesManager.Repositories;
using fw.Security;
using SQL.Provider;
using Imp.Entities;

namespace Imp.ServicesManager
{
    public class DVV_BLL : ServiceManager<DVV_BE>
    {
        public DVV_BLL() : base(new DVV_Repositorio())
        {
        }

        public void GenerarDVV()
        {
            bool ExisteDVV = false;
            string digito = string.Empty;
            UsuarioSQL usuSQL = new UsuarioSQL();

            foreach (DVV_BE item in ListAll())
            {
                if (item.nombre == "Usuario")
                {
                    ExisteDVV = true;
                    break;
                }
            }

            if (!ExisteDVV)
            {
                foreach (UsuarioBE item in usuSQL.ListAll())
                {
                    digito += GetDVH(item);
                }
                DVV_BE dvv = new DVV_BE();
                dvv.nombre = "Usuario";
                dvv.digitoVerificador = digito;
                this.Save(dvv);
            }
            else
            {
                DVV_BE dv = new DVV_BE();
                foreach (UsuarioBE item in usuSQL.ListAll())
                {
                    digito += GetDVH(item);
                }

                dv.nombre = "Usuario";
                dv.digitoVerificador = digito;
                this.Update(dv);
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
                if ((p.Name != "DVH") || (p.Name != "dvh"))
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

            foreach (UsuarioBE item in usuSQL.ListAll())
            {
                digito2 += GetDVH(item);
            }

            foreach (DVV_BE item in ListAll())
            {
                if (item.nombre == "Usuario")
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