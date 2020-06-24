using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HedraCloth.Startup))]
namespace HedraCloth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
