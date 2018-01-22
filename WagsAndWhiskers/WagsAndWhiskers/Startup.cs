using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WagsAndWhiskers.Startup))]
namespace WagsAndWhiskers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
