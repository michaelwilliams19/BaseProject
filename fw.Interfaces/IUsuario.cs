namespace fw.Interfaces
{
    public interface IUsuario : IBaseEntity
    {
        string nombreUsuario { get; set; } 
        string clave { get; set; }
    }
}
