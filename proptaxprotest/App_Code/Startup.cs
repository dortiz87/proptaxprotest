using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ptc_website.Startup))]
namespace ptc_website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
