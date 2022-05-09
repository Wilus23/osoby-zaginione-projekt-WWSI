using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projektzaginione.Startup))]
namespace projektzaginione
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
