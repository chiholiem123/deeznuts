using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMvcApp.Startup))]
namespace MyMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
