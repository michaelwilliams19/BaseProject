using System;
using System.Collections.Generic;
using fw.ServiceManager.Services;
using Imp.ServicesManagerEntities;
using fw.Interfaces;
using Imp.ServicesManager.Repositories;

namespace Imp.ServicesManager
{
    public class BitacoraUsuario_ServicioBLL : ServiceManager<BitacoraUsuario_ServicioBE>
    {
        BitacoraUsuario_ServicioBE BitacoraUsuarioBE = new BitacoraUsuario_ServicioBE();

        public BitacoraUsuario_ServicioBLL() : base(new BitacoraUsuario_ServicioRepo())
        {
        }

        public void RegistrarEnBitacora(IUsuario usuResponsable, IUsuario UsuAuditado)
        {
            BitacoraUsuarioBE.ID = UsuAuditado.ID;
            BitacoraUsuarioBE.nombreUsuario = UsuAuditado.nombreUsuario;
            BitacoraUsuarioBE.clave = UsuAuditado.clave;
            BitacoraUsuarioBE.fechaCreacion = UsuAuditado.fechaCreacion;
            BitacoraUsuarioBE.fechaEliminacion = UsuAuditado.fechaEliminacion;
            BitacoraUsuarioBE.FechaModificacion = Convert.ToString(DateTime.Now);
            BitacoraUsuarioBE.UsuarioResponsable = usuResponsable.nombreUsuario;

            base.Save(BitacoraUsuarioBE);
        }

        public List<BitacoraUsuario_ServicioBE> ObtenerHistorico(IUsuario usuBE)
        {
            List<BitacoraUsuario_ServicioBE> HistorialBE = new List<BitacoraUsuario_ServicioBE>();

            foreach (BitacoraUsuario_ServicioBE bitacoraBE in base.ListAll())
            {
                if (usuBE.ID == bitacoraBE.ID)
                {
                    HistorialBE.Add(bitacoraBE);
                }
            }
            return HistorialBE;
        }
    }
}