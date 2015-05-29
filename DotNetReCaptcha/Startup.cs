using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetReCaptcha.Startup))]
namespace DotNetReCaptcha
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
