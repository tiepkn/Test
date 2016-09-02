using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jenkins.Startup))]
namespace Jenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
