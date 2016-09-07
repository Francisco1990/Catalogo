using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServicioWeb.Startup))]
namespace ServicioWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
