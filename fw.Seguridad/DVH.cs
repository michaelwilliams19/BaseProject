using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.Interfaces;


namespace fw.Seguridad
{
    public class DVH 
    {           
        
        public static string GenerarDVH(Idvh BE)
        {
            string dvh = string.Empty;
            Type t = BE.GetType();

            var props = t.GetProperties();

            foreach (var p in props)
            {

                Console.WriteLine(p);
                if (p.PropertyType.FullName.Equals(typeof(DateTime).FullName))
                {
                    DateTime date = (DateTime)p.GetValue(BE);
                    BE.dvh += date.ToString("ddMMyyyy");
                }
                else
                {

                }
                {
                   BE.dvh += p.GetValue(BE);
                }
            }


            return BE.dvh;


        }



    }
}
