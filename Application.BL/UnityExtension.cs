using Application.DAL.Interfaces;
using Application.DAL.Repositories;
using Unity.Extension;
using Unity;


namespace AppWebApi
{
    public class UnityExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IApplicationRepository, ApplicationRepository>();

        }
    }
}



