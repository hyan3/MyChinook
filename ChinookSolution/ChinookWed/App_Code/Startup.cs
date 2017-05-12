using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChinookWed.Startup))]
namespace ChinookWed
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
