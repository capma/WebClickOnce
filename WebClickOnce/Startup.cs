using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebClickOnce.Startup))]
namespace WebClickOnce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
