using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testingmvc.Startup))]
namespace testingmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
