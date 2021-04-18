using fw.Interfaces;

namespace Imp.Validator
{
    public static class ValidatorGeneral
    {
        public static bool Validar<T>(this T BE) where T : IBaseEntity
        {
            var validator = ValidatorFactory.ObtenerValidator<T>();
            var nvc = validator.Validar(BE);

            if (nvc.Count > 0)
            {
               throw new ValidatorException(nvc);
            }

            return true;
        }
    }
}
