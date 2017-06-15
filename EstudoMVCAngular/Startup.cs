using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstudoMVCAngular.Startup))]
namespace EstudoMVCAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
