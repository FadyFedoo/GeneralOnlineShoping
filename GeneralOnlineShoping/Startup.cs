using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeneralOnlineShoping.Startup))]
namespace GeneralOnlineShoping
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
