using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kayak.Online.Shell.Startup))]
namespace Kayak.Online.Shell
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
