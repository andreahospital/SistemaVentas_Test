using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaFacturacion.Startup))]
namespace SistemaFacturacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
