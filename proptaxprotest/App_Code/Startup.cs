using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proptaxprotest.Startup))]
namespace proptaxprotest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
