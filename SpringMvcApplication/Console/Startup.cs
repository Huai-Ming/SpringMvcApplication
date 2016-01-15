using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Console.Startup))]
namespace Console
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
