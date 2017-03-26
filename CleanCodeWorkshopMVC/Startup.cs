using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CleanCodeWorkshopMVC.Startup))]
namespace CleanCodeWorkshopMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
