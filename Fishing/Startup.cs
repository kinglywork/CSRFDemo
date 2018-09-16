using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fishing.Startup))]
namespace Fishing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
