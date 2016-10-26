using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dev_tools.Startup))]
namespace dev_tools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
