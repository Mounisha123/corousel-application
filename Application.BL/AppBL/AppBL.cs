using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models.Models;
using Application.DAL.Repositories;
using Application.BL.Interfaces;
using Application.DAL.Interfaces;

namespace Application.BL.AppBL
{
    public class AppBL : IBL
    {
        
        private readonly IApplicationRepository _ApplicationRepository;
        public AppBL(IApplicationRepository ApplicationRepository)
        {
            _ApplicationRepository = ApplicationRepository;
        }
        

        public List<AppModel> GetAppData()
        {
            return _ApplicationRepository.GetAppData();
        }

        public List<AppModel> InsertAppData(AppModel saveData)
        {

            return _ApplicationRepository.InsertAppData(saveData);
        }

        public string UpdateAppData(int appId, AppModel value)
        {
            return _ApplicationRepository.UpdateAppData(appId, value);
        }

        public string DeleteAppData(int appId)
        {
            return _ApplicationRepository.DeleteAppData(appId);
        }
    }
}
