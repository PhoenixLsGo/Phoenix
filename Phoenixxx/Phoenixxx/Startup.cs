using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phoenixxx.Startup))]
namespace Phoenixxx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
