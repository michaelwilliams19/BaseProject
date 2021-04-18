using System.Collections.Specialized;

namespace fw.Interfaces
{
    public interface IValidator<T> where T : IBaseEntity
    {
        NameValueCollection Validar(T BE);
    }
}