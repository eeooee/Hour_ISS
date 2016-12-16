using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hour_ISS.Startup))]
namespace Hour_ISS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
