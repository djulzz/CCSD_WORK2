using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week01.Startup))]
namespace Week01
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
