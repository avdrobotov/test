using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebServer.Startup))]
namespace TestWebServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
