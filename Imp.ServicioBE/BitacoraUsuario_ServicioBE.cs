using fw.Interfaces;

namespace Imp.ServicesManagerEntities
{
    public class BitacoraUsuario_ServicioBE : fw.ServiceManagerEntities.ServiceManagerEntity, IUsuario
    {
        public string nombreUsuario { get; set; }
        public string clave { get; set; }
        public string BitacoraID { get; set; }
        public string FechaModificacion { get; set; }
        public string UsuarioResponsable { get; set; }
    }
}
