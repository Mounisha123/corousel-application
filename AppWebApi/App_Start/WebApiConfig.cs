
using Application.BL.AppBL;
using Application.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;
using Unity.Lifetime;


namespace AppWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.EnableCors(new EnableCorsAttribute("http://localhost:4200", headers: "*", methods: "*"));
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

                var container = new UnityContainer();
            container.RegisterType<IBL,AppBL>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
             container.AddNewExtension<UnityExtension>();


        }
    }
}
