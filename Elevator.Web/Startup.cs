using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Elevator.Web.Startup))]
namespace Elevator.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
