using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using fw.Interfaces;
using Imp.ServicesManagerEntities;
using System.Configuration;

namespace SQL.Provider
{
    public abstract class ContextoSQL<T> : IABM<T> where T : IBaseEntity
    {


        string obtenerString()
        {
            return ConfigurationManager.ConnectionStrings["ClinicaMedicaConnectionString"].ConnectionString;            
        }


        SqlConnection miConexion = new SqlConnection();

        public System.Data.DataSet CargarDataset(string SentenciaSQL)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {                
                miConexion = new SqlConnection(obtenerString());

                SqlDataAdapter MiDataAdapter = new SqlDataAdapter(SentenciaSQL, miConexion);

                miConexion.Open();
                MiDataAdapter.Fill(ds);
                miConexion.Close();
            }
            catch (Exception)
            {                
            }           

            return ds;
        }



        public int ABM_Asistentes(string SentenciaSql)
        {
            int resultado = 0;

            miConexion = new SqlConnection(obtenerString());

            SqlCommand MiCommandText = new SqlCommand(SentenciaSql, miConexion);

            miConexion.Open();
            resultado= Convert.ToInt32(MiCommandText.ExecuteNonQuery());
            miConexion.Close();

            return resultado;

        }

        public int ObtenerID(string SentenciaSql)
        {
            int resultado = 0;

            miConexion = new SqlConnection(obtenerString());

            SqlCommand MiCommandText = new SqlCommand(SentenciaSql, miConexion);

            miConexion.Open();
            resultado = Convert.ToInt32(MiCommandText.ExecuteScalar());            
            miConexion.Close();

            return resultado;
        }

        public void persistirDVV(string nombreTabla)
        {
            DVVContexto dvvSQL = new DVVContexto();
            DVV_BE miDVV = new DVV_BE();

            string digitoTabla = "";

            IList<T> ListaEntidad = new List<T>();
            ListaEntidad = this.ListAll();
            foreach (IBaseEntity item in ListaEntidad)
            {
                digitoTabla += item.dvh;
            }

            miDVV.nombre = nombreTabla;
            miDVV.digitoVerificador = digitoTabla;

            dvvSQL.Update(miDVV);

        }


        public abstract void Save(T BE);
        public abstract void Delete(T BE);
        public abstract IList<T> ListAll();
        public abstract void Update(T BE);
        

    }
}
