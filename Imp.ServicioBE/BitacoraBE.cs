namespace Imp.ServicesManagerEntities
{
    public class BitacoraBE : fw.ServiceManagerEntities.ServiceManagerEntity
    {
        public string UsuarioResponsable { get; set; }
        public TipoEvento EventoOcurrido { get; set; }
        public enum TipoEvento
        {
            Login = 1,
            Logout = 2,
            Backup = 3,
            Restore = 4
        };
    }
}