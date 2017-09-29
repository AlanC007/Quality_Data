using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quality_Data.Startup))]
namespace Quality_Data
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
