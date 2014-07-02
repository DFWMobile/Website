using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DFWMobile.Web.Startup))]
namespace DFWMobile.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
