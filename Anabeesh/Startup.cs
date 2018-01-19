using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Anabeesh.Startup))]
namespace Anabeesh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
