using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models.Models;

namespace Application.DAL.Interfaces
{
    public interface IApplicationRepository
    {
        List<AppModel> GetAppData();
        List<AppModel> InsertAppData(AppModel app);
        string UpdateAppData(int appId, AppModel data);
        string DeleteAppData(int appId);
    }
}
