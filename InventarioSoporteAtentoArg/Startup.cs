using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InventarioSoporteAtentoArg.Startup))]
namespace InventarioSoporteAtentoArg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
