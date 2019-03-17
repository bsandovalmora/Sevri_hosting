using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SitiosWeb.Startup))]
namespace SitiosWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
