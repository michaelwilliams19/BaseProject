using System;
using System.Text;
using System.Security.Cryptography;
using fw.Interfaces;

namespace fw.Security
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
            Usuario1.clave = Encriptar(Usuario1.clave);

            if (Usuario1.clave == Usuario2.clave)
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
