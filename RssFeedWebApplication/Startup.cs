using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RssFeedWebApplication.Startup))]
namespace RssFeedWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
