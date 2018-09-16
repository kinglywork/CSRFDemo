using Microsoft.Owin;
using Owin;
using Victim;

[assembly: OwinStartup(typeof(Startup))]
namespace Victim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
