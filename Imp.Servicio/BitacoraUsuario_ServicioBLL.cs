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

namespace Imp.Servicio
{
    public class BitacoraUsuario_ServicioBLL : Servicio<BitacoraUsuario_ServicioBE>

    {

        BitacoraUsuario_ServicioBE BitacoraUsuarioBE = new BitacoraUsuario_ServicioBE();


        public BitacoraUsuario_ServicioBLL() : base(new BitacoraUsuario_ServicioRepo())
        { }


        public void RegistrarEnBitacora(IUsuario usuResponsable, IUsuario UsuAuditado)
        {
            BitacoraUsuarioBE.ID = UsuAuditado.ID;
            BitacoraUsuarioBE.Nombre = UsuAuditado.Nombre;
            BitacoraUsuarioBE.NombreUsuario = UsuAuditado.NombreUsuario;
            BitacoraUsuarioBE.Clave = UsuAuditado.Clave;
            BitacoraUsuarioBE.FechaCreacion = UsuAuditado.FechaCreacion;
            BitacoraUsuarioBE.FechaEliminacion = UsuAuditado.FechaEliminacion;
            
            BitacoraUsuarioBE.FechaModificacion = Convert.ToString(DateTime.Now);
            BitacoraUsuarioBE.UsuarioResponsable = usuResponsable.NombreUsuario;

            base.Alta(BitacoraUsuarioBE);        
            
        }


        public  List<BitacoraUsuario_ServicioBE> ObtenerHistorico(IUsuario usuBE)
        {
            List<BitacoraUsuario_ServicioBE> HistorialBE = new List<BitacoraUsuario_ServicioBE>();

            foreach(BitacoraUsuario_ServicioBE bitacoraBE in base.Listar())
            {
                if(usuBE.ID == bitacoraBE.ID)
                {
                    HistorialBE.Add(bitacoraBE);

                }

                
            }
            return HistorialBE;
        }



    }
}
