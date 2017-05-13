using Microsoft.Practices.Unity;
using Mobinor.BusinessServices;
using Mobinor.BusinessServices.Interfaces;
using Mobinor.Repository.Classes;
using Mobinor.Repository.Interfaces;
using System.Web.Http;
using System.Web.Mvc;

namespace MobinorWeb
{
    /// <summary>
    /// Class for Unity Config
    /// </summary>
    public static class UnityConfig
    {
        /// <summary>
        /// Register Components
        /// </summary>
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IDailersInfoService, DailersInfoService>();
            container.RegisterType<IDailersInfoRepository, DailersInfoRepository>();

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}