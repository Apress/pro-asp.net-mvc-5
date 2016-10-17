using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DebuggingDemo.Startup))]
namespace DebuggingDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
