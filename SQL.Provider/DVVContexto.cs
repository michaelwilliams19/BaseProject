﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServicioBE;
using Imp.ServicioBE;

namespace SQL.Provider
{
    public class DVVContexto : ContextoSQL<DVV_BE>
    {
        public override void Alta(DVV_BE BE)
        {
            string sentenciaAlta = string.Format("insert into DVV(ID,nombreTabla, fechaCreacion,fechaEliminacion, digitoVerificador,dvh) values('{0}','{1}','{2}','{3}','{4}','{5}')", BE.ID, BE.Nombre, BE.FechaCreacion, BE.FechaEliminacion, BE.digitoVerificador,BE.dvh);
            this.ABM_Asistentes(sentenciaAlta);
        }

        public override void Baja(DVV_BE BE)
        {
            throw new NotImplementedException();
        }

        public override IList<DVV_BE> Listar()
        {
            string SentenciaListar = string.Format("select * from DVV");
            List<DVV_BE> ListaDVV = new List<DVV_BE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    DVV_BE miDVV = new DVV_BE();

                    CargarDVV(miDVV, fila);
                    ListaDVV.Add(miDVV);
                }
            }
            return ListaDVV;
        }

        public void CargarDVV(DVV_BE unDVV, System.Data.DataRow Fila)
        {
            try
            {
                unDVV.ID = Convert.ToString(Fila["ID"]);
                unDVV.Nombre = Convert.ToString(Fila["NombreTabla"]);
                unDVV.dvh = Convert.ToString(Fila["Dvh"]);
                unDVV.FechaCreacion = Convert.ToString(Fila["fechaCreacion"]);
                unDVV.FechaEliminacion = Convert.ToString(Fila["fechaEliminacion"]);
                unDVV.digitoVerificador = Convert.ToString(Fila["digitoVerificador"]);
            }
            catch (Exception)
            {

                
            }
          
        }

        public override void Modificar(DVV_BE BE)
        {
            string sentenciaModificar = string.Format("update DVV set DigitoVerificador='{0}', DVH='{1}' where nombreTabla='{2}'", BE.digitoVerificador, BE.dvh, BE.Nombre);

            this.ABM_Asistentes(sentenciaModificar);
            
        }    
                           
    }
}
