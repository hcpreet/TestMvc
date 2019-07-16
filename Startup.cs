using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebNextData.Startup))]
namespace WebNextData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
