using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Application.DAL.Interfaces;
using Application.Models.Models;


namespace Application.DAL.Repositories
{
    public class ApplicationRepository:BaseRepository,IApplicationRepository
    {
        public List<AppModel> GetAppData()
        {
            List<AppModel> GetAllApp = new List<AppModel>();
            using (var dataset = GetDataset(ProcedureNames.getDetails))
            {
                var App = dataset.Tables[0];
                var AppTableDetail = App.AsEnumerable();

                foreach (var AppRow in AppTableDetail)
                {
                    GetAllApp.Add(PopulateData<AppModel>(AppRow));
                }
            }
            return GetAllApp;

        }


        public List<AppModel> InsertAppData(AppModel app)
        {
            List<AppModel> appInsert = new List<AppModel>();
            using (var dataset = GetDataset(ProcedureNames.proc_insertApp,
                    new SqlParameter("@appName", app.appName),                 
                     new SqlParameter("@appDesp", app.appDesp),
                     new SqlParameter("@isDeleted", app.isDeleted)))

            {
                try
                {
                    var App = dataset.Tables[0];
                    var AppTableDetail =App.AsEnumerable();

                    foreach (var AppRow in AppTableDetail)
                    {
                        appInsert.Add(PopulateData<AppModel>(AppRow));
                    }

                }
                catch (Exception io)
                {
                    Console.WriteLine(io);
                }

            }
            return appInsert;
        }

        public string UpdateAppData(int appId, AppModel data)
        {
            var status = GetValue<string>(ProcedureNames.proc_updateApp,
            new SqlParameter("@appId", appId),
            new SqlParameter("@appName", data.appName),
            new SqlParameter("@appDesp", data.appDesp));
           
            return status;
        }

        public string DeleteAppData(int appId)
        {
            var status = GetValue<string>(ProcedureNames.softDelete,
            new SqlParameter("@appId", appId));
            return status;
        }
    }
}
