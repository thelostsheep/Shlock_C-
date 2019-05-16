using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shlock_A.Startup))]
namespace Shlock_A
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
