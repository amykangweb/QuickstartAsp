using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuickStartAsp.Startup))]
namespace QuickStartAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
