using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OdeToBeer.Startup))]
namespace OdeToBeer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
