using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bibabook.Startup))]
namespace Bibabook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
