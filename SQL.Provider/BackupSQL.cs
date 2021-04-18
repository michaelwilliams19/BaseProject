using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.ServiceManagerEntities;
using Imp.ServicesManagerEntities;

namespace SQL.Provider
{
    public class BackupSQL : ContextoSQL<Backup_ServicioBE>
    {
        public override void Save(Backup_ServicioBE BE)
        {
            string SentenciaAlta = string.Format("insert into Backap(Backup_id,Backup_Nombre,Backup_Ruta,Backup_Fechacreacion,Backup_Fechaeliminacion)values('{0}','{1}','{2}','{3}','{4}')", BE.ID, BE.NombreBackup, BE.Ruta, BE.fechaCreacion, BE.fechaEliminacion);
            this.ABM_Asistentes(SentenciaAlta);

                       
            BE.Ruta = string.Format("{0}\\{1}", BE.Ruta, BE.NombreBackup);
            string SentenciaBackup = string.Format("USE MASTER; BACKUP DATABASE ClinicaMedica TO DISK = '{0}.bak'", BE.Ruta);            
            this.ABM_Asistentes(SentenciaBackup);        
                                                  
           
        }


        public void RealizarRestore(Backup_ServicioBE backupBE)
        {
            backupBE.Ruta = string.Format("{0}\\{1}", backupBE.Ruta, backupBE.NombreBackup);
            string SentenciaRestore = string.Format("USE MASTER; ALTER DATABASE ClinicaMedica SET OFFLINE With ROLLBACK IMMEDIATE RESTORE DATABASE ClinicaMedica FROM DISK = '{0}.bak' With REPLACE, STATS = 10", backupBE.Ruta);

            this.ABM_Asistentes(SentenciaRestore);

            string sentenciaBD = string.Format("USE MASTER; Alter database ClinicaMedica SET ONLINE");
            this.ABM_Asistentes(sentenciaBD);
        }

        public override void Delete(Backup_ServicioBE BE)
        {
            throw new NotImplementedException();
        }

        public override IList<Backup_ServicioBE> ListAll()
        {
            string SentenciaListar = string.Format("select * from backap");
            List<Backup_ServicioBE> ListaBackups = new List<Backup_ServicioBE>();

            System.Data.DataSet MiDataset = new System.Data.DataSet();

            MiDataset = this.CargarDataset(SentenciaListar);

            if (MiDataset.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow fila in MiDataset.Tables[0].Rows)
                {
                    Backup_ServicioBE backupBE = new Backup_ServicioBE();

                    CargarBackups(backupBE, fila);
                    ListaBackups.Add(backupBE);

                }

            }
            return ListaBackups ;
        }


        public void CargarBackups(Backup_ServicioBE backupBE, System.Data.DataRow Fila)
        {
            backupBE.ID = Convert.ToString(Fila["backup_ID"]);
            backupBE.NombreBackup = Convert.ToString(Fila["backup_nombre"]);
            backupBE.Ruta = Convert.ToString(Fila["backup_ruta"]);            
            backupBE.fechaCreacion = Convert.ToDateTime(Fila["backup_FechaCreacion"]);
            backupBE.fechaEliminacion = Convert.ToDateTime(Fila["backup_FechaEliminacion"]);
        }

        public override void Update(Backup_ServicioBE BE)
        {
            throw new NotImplementedException();
        }

        public int ObtenerProximoID()
        {
            int resultado = 0;

            string SentenciaID = string.Format("select isnull(max(backup_id),0) from backup");

            resultado = this.ObtenerID(SentenciaID);
            resultado += 1;

            return resultado;


        }


    }
}
