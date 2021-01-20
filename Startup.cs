using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArhiCRMv2.Startup))]
namespace ArhiCRMv2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
