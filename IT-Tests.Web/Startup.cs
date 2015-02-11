using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_Tests.Web.Startup))]
namespace IT_Tests.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
