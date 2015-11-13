using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecondMvcApp.Startup))]
namespace SecondMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
