using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MobinorWeb.Startup))]
namespace MobinorWeb
{
    /// <summary>
    /// Partial Class StartUp
    /// </summary>
    public partial class Startup
    {
        /// <summary>
        /// Method of Configuration
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
