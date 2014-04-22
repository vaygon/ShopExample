using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopApplication.Startup))]
namespace ShopApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
