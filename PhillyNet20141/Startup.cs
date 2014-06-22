using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhillyNet20141.Startup))]
namespace PhillyNet20141
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
