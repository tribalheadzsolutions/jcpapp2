using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jcp_app2.Startup))]
namespace jcp_app2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
