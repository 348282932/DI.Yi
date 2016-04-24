using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DI.YI.Startup))]
namespace DI.YI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
