using System;
using System.Reflection;
using fw.Interfaces;
using fw.Validator;

namespace Imp.Validator
{
    public class ValidatorFactory
    {
        public static IValidator<T> ObtenerValidator<T>() where T : IBaseEntity
        {
            var t = typeof(T);
            string name = string.Format("{0}Validator", t.Name);

            try
            {
                var ns = "Imp.ValidatorBE";

                #region "intentosreflection"
                // Assembly m_assembly = Assembly.LoadFrom("Implementacion.Imp.Validator.dll");
                //Type m_type = m_assembly.GetType(t.Name);
                //IValidator<T> m_clase = (IValidator<T>)Activator.CreateInstance(m_type);
                //IValidator <T> validator = (IValidator<T>)Assembly.CreateInstance(string.Format("{0}.{1}",ns, name));
                // IValidator<T> validator = (IValidator<T>)Assembly.Load(ns).CreateInstance(string.Format("{0}.{1}",ns, name));
                // IValidator<T> validator = (IValidator<T>)Assembly.GetExecutingAssembly().CreateInstance(string.Format("{0}.{1}",ns, name));
                //(IValidator<T>)Assembly.LoadFrom(ns).CreateInstance(string.Format("{0}.{1}", ns, name));

                //var ruta = Path.Combine(AppContext.BaseDirectory, "Imp.Validator.dll");

                //Assembly miEnsamblado = Assembly.LoadFile(ruta);

                //IValidator<T> validator = miEnsamblado.CreateInstance("Imp.ValidatorBE.UsuarioBEValidator") as IValidator<T>;
                #endregion

                IValidator<T> validator = (IValidator<T>)Assembly.Load(ns).CreateInstance(String.Format("{0}.{1}",ns, name));                         

                return validator == null ? new MockValidator<T>() : validator;
            }
            catch (Exception)
            {
                return new MockValidator<T>();
            }       
        }
    }
}