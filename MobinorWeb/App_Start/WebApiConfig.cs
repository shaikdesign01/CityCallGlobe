using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MobinorWeb.App_Start
{
    /// <summary>
    /// Class for WebApi Config
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registering Web Api Route
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            // TODO: Add any additional configuration code.

            //config.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}