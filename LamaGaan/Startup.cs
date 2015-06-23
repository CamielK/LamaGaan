using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LamaGaan.Startup))]
namespace LamaGaan
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
