using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMvcApplication.Startup))]
namespace MyMvcApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
