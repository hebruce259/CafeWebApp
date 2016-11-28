using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coffeshopapp.Startup))]
namespace Coffeshopapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
