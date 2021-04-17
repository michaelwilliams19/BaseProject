using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using fw.Interfaces;


namespace fw.Seguridad
{
   public class Encriptacion
    {

        

        public string Encriptar(string clave)
        {
            MD5 md5Hash = MD5.Create();
            
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(clave));
                                    
            StringBuilder sBuilder = new StringBuilder();
                        
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
                        
            return sBuilder.ToString();
        }


        public Boolean Comparar(IUsuario Usuario1, IUsuario Usuario2)
        {
            Boolean rta;
            Usuario1.Clave = Encriptar(Usuario1.Clave);

            if(Usuario1.Clave == Usuario2.Clave)
            {
                
                rta = true;
                

            }
            else
            {
                rta = false;
            }
            return rta;

        }

    }
}
