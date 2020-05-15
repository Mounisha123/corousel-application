using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models.Models;

namespace Application.BL.Interfaces
{
    public interface IBL
    {
        List<AppModel> GetAppData();
        List<AppModel> InsertAppData(AppModel saveData);
        string UpdateAppData(int appId, AppModel value);
        string DeleteAppData(int appId);
    }
}
